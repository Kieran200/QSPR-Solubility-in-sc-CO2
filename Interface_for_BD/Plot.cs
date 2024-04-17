using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Interface_for_BD
{
    public partial class Plot : Form
    {
        private double a, b, h;
        private double x, y;
        private List<double> list_of_x = new List<double>();
        private List<double> list_of_y = new List<double>();
        private double solub = 0;
        Equation eq = new Equation();

        private void jpegToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfd.Filter = "JPeg Image|*.jpg";
            sfd.ShowDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                chart1.SaveImage(sfd.FileName, ChartImageFormat.Jpeg);
            }
        }

        public Plot()
        {
            InitializeComponent();
            Init_Chart();
            Points();
            
            //заметка
            TextAnnotation TA1 = new TextAnnotation();
            TA1.Text += "Вещества:";//Equation.equation;
            for (int i = 0; i < Equation.LSubName.Count; i++)
            {
                TA1.Text += "\n" + Equation.LSubName[i];
            }
            TA1.Text += "\n";
            TA1.Text += "Дескрипторы:";
            for (int i = 0; i < Equation.LDescName.Count; i++)
            {
                TA1.Text += "\n" + Equation.LDescName[i];
            }
            TA1.Text += "\n";
            TA1.Text += "\n";
            TA1.Text += "Уравнение:";
            TA1.Text += "\n";
            for (int i = 0; i < Equation.LDesc.Count; i++)
            {
                TA1.Text += Equation.FinalCoefList[i];
                TA1.Text += " * ";
                TA1.Text += Equation.LDescName[i];
                TA1.Text += " + ";
                TA1.Text += "\n";
            }
            if (Equation.FinalCoefList.Count != 0)
            {
                TA1.Text += Equation.FinalCoefList[Equation.FinalCoefList.Count - 2];
                TA1.Text += " * p";
                TA1.Text += "\n";
                TA1.Text += Equation.FinalCoefList[Equation.FinalCoefList.Count - 1];
                TA1.Text += " * 1/T";
            }

            TA1.AnchorX = 85;
            TA1.AnchorY = 100;
            chart1.Annotations.Add(TA1);
        }
        public void Init_Chart()
        {
            this.chart1.Series[0].Points.Clear();
            a = 0;
            b = 1;
            h = 0.2;
            x = a;
            while (x <= b)
            {
                y = x;
                this.chart1.Series[0].Points.AddXY(x, y);
                x += h;
            }
        }
        public void Points () 
        {
            string ConnectionString = "Server=KIERAN; Database=DB_Descriptors_1;Trusted_Connection=True; MultipleActiveResultSets=True";
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();


            for (int i = 0; i < Equation.LSub.Count; i++)
            {
                solub = 0;
                //находим расчетную растворимость вещества (составляющие - дескрипторы)
                for (int j = 0; j < Equation.LDesc.Count; j++)
                {
                    string query = string.Format("SELECT DISTINCT DescriptorsDictionary.Value\r\n\tFROM DescriptorsDictionary, Descriptors, Substances\r\n\tWHERE DescriptorsDictionary.DescriptorId = {0} AND DescriptorsDictionary.SubstanceId = {1}", Equation.LDesc[j], Equation.LSub[i]);
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            solub += Convert.ToDouble(reader.GetValue(0)) * Equation.FinalCoefList[j];
                        }
                    }
                    reader.Close();
                }

                //расчетная растворимость (составляюшие - давление и температура)
                string count_query = string.Format("SELECT COUNT(*) FROM Experiments, Points, Substances WHERE Points.ExperimentId = Experiments.Id AND Experiments.SubstanceId = Substances.Id AND Substances.Id = {0}", Equation.LSub[i]);
                SqlCommand command1 = new SqlCommand(count_query, connection);
                SqlDataReader reader1 = command1.ExecuteReader();
                int count = 0;
                if (reader1.HasRows)
                {
                    while (reader1.Read())
                    {
                        count = Convert.ToInt32(reader1.GetValue(0));
                    }
                }
                double solub_clone = solub;
                for (int k = 1; k <= count; k++)
                {
                    solub = solub_clone;
                    string query_eq = string.Format("SELECT TOP({1})  Experiments.Id, Points.Id, Points.Pressure, Points.Temperature, Points.Value FROM Experiments, Points, Substances WHERE Points.ExperimentId = Experiments.Id AND Experiments.SubstanceId = Substances.Id AND Substances.Id = {0} EXCEPT SELECT TOP({2})  Experiments.Id, Points.Id, Points.Pressure, Points.Temperature, Points.Value FROM Experiments, Points, Substances WHERE Points.ExperimentId = Experiments.Id AND Experiments.SubstanceId = Substances.Id AND Substances.Id = {0}", Equation.LSub[i], k, k - 1);
                    SqlCommand command3 = new SqlCommand(query_eq, connection);
                    SqlDataReader reader3 = command3.ExecuteReader();

                    if (reader3.HasRows)
                    {
                        while (reader3.Read())
                        {
                            solub += Convert.ToDouble(reader3.GetValue(2)) * Equation.FinalCoefList[Equation.FinalCoefList.Count - 2];
                            solub += (1 / Convert.ToDouble(reader3.GetValue(3))) * Equation.FinalCoefList[Equation.FinalCoefList.Count - 1];
                            list_of_x.Add(Convert.ToDouble(reader3.GetValue(4))); 
                            list_of_y.Add(solub);
                        }
                    }
                }
            }
            for (int i = 0; i < list_of_x.Count; i++)
            {
                this.chart1.Series[1].Points.AddXY(list_of_x[i], list_of_y[i]);
            }
        }
    }
}
