using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;

namespace Interface_for_BD
{
    public partial class frmCluster : Form
    {
        public frmCluster()
        {
            InitializeComponent();
        }
        List<List<string>> Datalist = new List<List<string>>();
        List<string> Substanceslist = new List<string>();
        List<string> SubstancesIdlist = new List<string>();
        List<string> Descriptorslist = new List<string>();


        private void btnClusterExcel_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Server=KIERAN; Database=DB_Descriptors_1;Trusted_Connection=True; MultipleActiveResultSets=True");
            connection.Open();

            string query = string.Format("SELECT Descriptors.Marker \r\nFROM Descriptors");
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();


            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Descriptorslist.Add(reader.GetString(0));
                    List<string> FirstDatalist = new List<string>();
                }
            }
            string query3 = string.Format("SELECT DISTINCT Substances.Id, Substances.Name \r\nFROM Experiments, Points, Substances, Density, DescriptorsDictionary, Descriptors\r\nWHERE Points.ExperimentId = Experiments.Id AND \r\nExperiments.SubstanceId = Substances.Id AND \r\nDensity.Temperature = Points.Temperature AND \r\nDensity.Pressure = Points.Pressure AND Density.SubstanceId = '4791' AND\r\nDescriptors.Id = DescriptorsDictionary.DescriptorId AND\r\nDescriptorsDictionary.SubstanceId = Substances.Id AND \r\nSubstances.Id = DescriptorsDictionary.SubstanceId AND \r\nPoints.Value != 0 AND  \r\nPoints.ExperimentId = Experiments.Id AND  \r\nExperiments.SubstanceId = Substances.Id");
            SqlCommand command3 = new SqlCommand(query3, connection);
            SqlDataReader reader3 = command3.ExecuteReader();
            if (reader3.HasRows)
            {
                while (reader3.Read())
                {
                    Substanceslist.Add(Convert.ToString(reader3.GetValue(1)));
                    SubstancesIdlist.Add(Convert.ToString(reader3.GetValue(0)));
                }
            }

            for (int j = 0; j < Descriptorslist.Count; j++)
            {
                List<string> FirstDatalist = new List<string>();
                for (int i = 0; i < SubstancesIdlist.Count; i++)
                {
                    string query2 = string.Format("SELECT DISTINCT Substances.Name, DescriptorsDictionary.Value\r\nFROM Experiments, Points, Substances, Density, DescriptorsDictionary, Descriptors\r\nWHERE Points.ExperimentId = Experiments.Id AND \r\nExperiments.SubstanceId = Substances.Id AND \r\nDensity.Temperature = Points.Temperature AND \r\nDensity.Pressure = Points.Pressure AND Density.SubstanceId = '4791' AND\r\nDescriptors.Id = DescriptorsDictionary.DescriptorId AND\r\nDescriptorsDictionary.SubstanceId = Substances.Id AND \r\nSubstances.Id = DescriptorsDictionary.SubstanceId AND \r\nPoints.Value != 0 AND  \r\nPoints.ExperimentId = Experiments.Id AND  \r\nExperiments.SubstanceId = Substances.Id AND\r\nDescriptors.Marker = '{0}' AND Substances.Id = '{1}' ", Descriptorslist[j], SubstancesIdlist[i]);
                    SqlCommand command2 = new SqlCommand(query2, connection);
                    SqlDataReader reader2 = command2.ExecuteReader();

                    if (reader2.HasRows)
                        while (reader2.Read())
                            FirstDatalist.Add(Convert.ToString(reader2.GetValue(1)));
                    else
                        FirstDatalist.Add("NULL");
                }
                Datalist.Add(FirstDatalist);
            }

            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            ExcelApp.Application.Workbooks.Add(Type.Missing);

            for (int i = 0; i < Descriptorslist.Count; i++)
            {
                ExcelApp.Cells[i + 2, 1] = Descriptorslist[i];
            }
            for (int i = 0; i < Substanceslist.Count; i++)
            {
                ExcelApp.Cells[1, i + 2] = Substanceslist[i];
            }
            for (int i = 0; i < Datalist[i].Count; i++)
            {
                for (int j = 0; j < Datalist.Count; j++)
                {
                    if (Datalist[j][i] != "NULL")
                        ExcelApp.Cells[j + 2, i + 2] = Convert.ToDouble(Datalist[j][i]);
                    else
                        ExcelApp.Cells[j + 2, i + 2] = Datalist[j][i];
                }
            }
            Microsoft.Office.Interop.Excel.Worksheet Sheet;
            Sheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelApp.Sheets[1];
            ExcelApp.Visible = true;

        }
    }
}
