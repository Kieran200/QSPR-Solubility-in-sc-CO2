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

        public Plot()
        {
            InitializeComponent();
            Init_Chart();
            Points();
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
                    string query_eq = string.Format("SELECT TOP({1}) Points.Pressure, Points.Temperature, Points.Value FROM Experiments, Points, Substances WHERE Points.ExperimentId = Experiments.Id AND Experiments.SubstanceId = Substances.Id AND Substances.Id = {0} EXCEPT SELECT TOP({2}) Points.Pressure, Points.Temperature, Points.Value FROM Experiments, Points, Substances WHERE Points.ExperimentId = Experiments.Id AND Experiments.SubstanceId = Substances.Id AND Substances.Id = {0}", Equation.LSub[i], k, k - 1);
                    SqlCommand command3 = new SqlCommand(query_eq, connection);
                    SqlDataReader reader3 = command3.ExecuteReader();

                    if (reader3.HasRows)
                    {
                        while (reader3.Read())
                        {
                            solub += Convert.ToDouble(reader3.GetValue(0)) * Equation.FinalCoefList[Equation.FinalCoefList.Count - 2];
                            solub += (1 / Convert.ToDouble(reader3.GetValue(1))) * Equation.FinalCoefList[Equation.FinalCoefList.Count - 1];
                            list_of_x.Add(solub);
                            list_of_y.Add(Convert.ToDouble(reader3.GetValue(2)));
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
