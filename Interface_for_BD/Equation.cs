using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Drawing;
using System.Collections;
using System.Text.RegularExpressions;

namespace Interface_for_BD
{
    public partial class Equation : Form
    {
        public static List<string> LSub = new List<string>();
        public static List<string> LDesc = new List<string>();

        public Equation()
        {
            InitializeComponent();

            string ConnectionString = "Server=KIERAN; Database=DB_Descriptors_1;Trusted_Connection=True; ";
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            string query = string.Format("SELECT Substances.Name, Substances.Id FROM Substances");
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Substances sub = new Substances() { Id = Convert.ToInt32(reader.GetValue(1)), Name = Convert.ToString(reader.GetValue(0)) };
                    cLB_sub.Items.Add(sub);
                }
            }
            reader.Close();
        }

        private void but_sub_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Server=KIERAN; Database=DB_Descriptors_1;Trusted_Connection=True; ";
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            //сбор всех возможных дескрипторов выбранных веществ
            List<List<string>> desc_List = new List<List<string>>();
            for (int i = 0; i < cLB_sub.CheckedItems.Count; i++)
            {
                List<string> desc = new List<string>();
                desc_List.Add(desc);
                LSub.Add(((Substances)cLB_sub.CheckedItems[i]).Id.ToString());
                string query_for_desc = string.Format("SELECT DISTINCT Descriptors.Id FROM Descriptors, DescriptorsDictionary, Substances, Points, Experiments WHERE Descriptors.Id = DescriptorsDictionary.DescriptorId AND Substances.Id = DescriptorsDictionary.SubstanceId AND Substances.Id = {0} AND DescriptorsDictionary.Value != 0 AND Points.Value != 0 AND  Points.ExperimentId = Experiments.Id AND Experiments.SubstanceId = Substances.Id AND Descriptors.Name IS NOT NULL", ((Substances)cLB_sub.CheckedItems[i]).Id.ToString());
                SqlCommand command1 = new SqlCommand(query_for_desc, connection);
                SqlDataReader reader1 = command1.ExecuteReader();

                if (reader1.HasRows)
                {
                    while (reader1.Read())
                    {
                        desc_List[i].Add(Convert.ToString(reader1.GetValue(0)));
                    }
                }
                reader1.Close();
            }
            
            //отбор общих дескрипторов
            for (int i = 1; i < desc_List.Count; i++)
                for (int j = 0; j < desc_List[0].Count; j++)
                {
                    if (desc_List[i].Contains(desc_List[0][j]))
                        continue;
                    else desc_List[0].RemoveAt(j);
                }
            string name = "";
            for (int i = 0; i < desc_List[0].Count; i++)
            {
                string query_for_desc = string.Format("SELECT DISTINCT Descriptors.Name, Descriptors.Marker \r\n\tFROM Descriptors, DescriptorsDictionary\r\n\tWHERE Descriptors.Id = DescriptorsDictionary.DescriptorId AND\r\n\tDescriptorsDictionary.DescriptorId = {0}", desc_List[1][i]);
                SqlCommand command2 = new SqlCommand(query_for_desc, connection);
                SqlDataReader reader2 = command2.ExecuteReader();

                if (reader2.HasRows)
                {
                    while (reader2.Read())
                    {
                        name = Convert.ToString(reader2.GetValue(0));
                    }
                }
                Descriptors desc = new Descriptors() { Id = Convert.ToInt32(desc_List[0][i]), Name = name };
                cLB_Desc.Items.Add(desc);
                reader2.Close();
            }
            connection.Close();
        }

        List<double> Values = new List<double>();
        double solub;
        string equation;
        List<List<double>> eqList = new List<List<double>>();
        List<double> solubList = new List<double>();
        public static List<double> FinalCoefList = new List<double>();
        private void but_eqs_Click(object sender, EventArgs e)
        {
            List<double> coefList = new List<double>();
            string ConnectionString = "Server=KIERAN; Database=DB_Descriptors_1;Trusted_Connection=True; MultipleActiveResultSets=True";
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            for (int i = 0; i < cLB_sub.CheckedItems.Count; i++)
            {
                //добавляем давление, температуру и растворимость iго вещества
                string count_query = string.Format("SELECT COUNT(*) FROM Experiments, Points, Substances WHERE Points.ExperimentId = Experiments.Id AND Experiments.SubstanceId = Substances.Id AND Substances.Id = {0}", ((Substances)cLB_sub.CheckedItems[i]).Id);
                SqlCommand command = new SqlCommand(count_query, connection);
                SqlDataReader reader = command.ExecuteReader();
                int count = 0;
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        count = Convert.ToInt32(reader.GetValue(0));
                    }
                }
                //получаем уравнения для первых 10 экспериментальных точек вещества во избежание перегруза программы
                for (int k = 1; k <= count; k++)
                {
                    if (k > 2)
                        break;
                    //добавляем дескрипторы для iго вещества
                    for (int j = 0; j < cLB_Desc.CheckedItems.Count; j++)
                    {
                        if (i == 0 && j == 0 && k == 0)
                            LDesc.Add(((Descriptors)cLB_Desc.CheckedItems[j]).Id.ToString());
                        string query = string.Format("SELECT TOP(1) DescriptorsDictionary.Value FROM  Descriptors, Substances, DescriptorsDictionary WHERE {0} = DescriptorsDictionary.DescriptorId AND {1} = DescriptorsDictionary.SubstanceId", ((Descriptors)cLB_Desc.CheckedItems[j]).Id, ((Substances)cLB_sub.CheckedItems[i]).Id);
                        SqlCommand command4 = new SqlCommand(query, connection);
                        SqlDataReader reader4 = command4.ExecuteReader();
                        if (reader4.HasRows)
                        {
                            while (reader4.Read())
                            {
                                Values.Add(Convert.ToDouble(reader4.GetValue(0)));
                            }
                        }
                    }
                    string query_eq = string.Format("SELECT TOP({1}) Points.Pressure, Points.Temperature, Points.Value FROM Experiments, Points, Substances WHERE Points.ExperimentId = Experiments.Id AND Experiments.SubstanceId = Substances.Id AND Substances.Id = {0} EXCEPT SELECT TOP({2}) Points.Pressure, Points.Temperature, Points.Value FROM Experiments, Points, Substances WHERE Points.ExperimentId = Experiments.Id AND Experiments.SubstanceId = Substances.Id AND Substances.Id = {0}", ((Substances)cLB_sub.CheckedItems[i]).Id, k, k-1);
                    SqlCommand command3 = new SqlCommand(query_eq, connection);
                    SqlDataReader reader3 = command3.ExecuteReader();
                    if (reader3.HasRows)
                    {
                        while (reader3.Read())
                        {
                            Values.Add(Convert.ToDouble(reader3.GetValue(0)));
                            Values.Add(1 / Convert.ToDouble(reader3.GetValue(1)));
                            solub = (Convert.ToDouble(reader3.GetValue(2)));
                        }
                    }
                    GA ga = new GA();
                    ga.Genetic_Algorithm(Values, solub, out coefList); //максимальное значение коэффициента - до 1
                    for (int j = 0; j < coefList.Count - 2; j++)
                        equation += (Convert.ToString(coefList[j]) + " * d" + Convert.ToString(j + 1) + " + ");
                    equation += (coefList[coefList.Count - 2] + " * p" + " + ");
                    equation += (coefList[coefList.Count - 1] + " * 1/T");

                    rTB_Eqs.Text += equation;
                    equation = "";
                    eqList.Add(coefList);
                    solubList.Add(solub);
                    Values.Clear();
                }
            }
            connection.Close();

            Average_Eq ae = new Average_Eq();
            ae.Average_Equations(eqList, solubList, out FinalCoefList);
            equation = "";
            for (int i = 0; i < FinalCoefList.Count - 2; i++)
                equation += (Convert.ToString(FinalCoefList[i]) + " * d" + Convert.ToString(i + 1) + " + ");
            equation += (FinalCoefList[FinalCoefList.Count - 2] + " * p" + " + ");
            equation += (FinalCoefList[FinalCoefList.Count - 1] + " * 1/T");
            rTB_Fin_Eq.Text = equation;
        }

        //классы, используемые для создание чек-лист боксов
        class Descriptors
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public override string ToString()
            {
                return Name;
            }
        }
        class Substances
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public override string ToString()
            {
                return Name;
            }
        }
        private void Btn_Plot_Click(object sender, EventArgs e)
        {
            Plot pl = new Plot();
            pl.Show();
        }
    }
}
