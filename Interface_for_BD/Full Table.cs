using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Remoting.Messaging;

namespace Interface_for_BD
{
    public partial class Full_Table : Form
    {
        public Full_Table()
        {
            InitializeComponent();
        }
        private void btn_table_view_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Server=KIERAN; Database=DB_Descriptors_1;Trusted_Connection=True; ";

            using (SqlConnection connection_2 = new SqlConnection(ConnectionString))
            {
                dgvExperimentsView.Rows.Clear();
                connection_2.Open();
                string query_2 = string.Format("SELECT Points.ExperimentId, Points.Value, Points.Temperature, Points.Pressure FROM Experiments, Points, Substances WHERE Points.Id IS NOT NULL AND Points.ExperimentId = Experiments.Id AND  Experiments.SubstanceId = Substances.Id AND Substances.Id = {0}", ((SubstanceView)cbSubstancesNameExp.SelectedItem).Id.ToString());
                SqlCommand command_2 = new SqlCommand(query_2, connection_2);
                SqlDataReader reader_2 = command_2.ExecuteReader();
                if (reader_2.HasRows)
                {
                    while (reader_2.Read())
                    {
                        var Id = reader_2.GetValue(0);
                        var Solubility = reader_2.GetValue(1);
                        var Temperature = reader_2.GetValue(2);
                        var Pressure = reader_2.GetValue(3);
                        dgvExperimentsView.Rows.Add(Id, Solubility, Temperature, Pressure);
                    }
                }
            }
        }
        public class ComboboxItem
        {
            public List<string> Text = new List<string>();
            public List<object> Value = new List<object>();
        }
        private void Full_Table_Load(object sender, EventArgs e)
        { 
            string ConnectionString = "Server=KIERAN; Database=DB_Descriptors_1;Trusted_Connection=True; ";
            using (SqlConnection connection_2 = new SqlConnection(ConnectionString))
            {
                connection_2.Open();
                string cmb_1 = string.Format("SELECT Substances.Name, Substances.Id FROM Substances");
                SqlCommand command_2 = new SqlCommand(cmb_1, connection_2);
                SqlDataReader reader_2 = command_2.ExecuteReader();
                if (reader_2.HasRows)
                {
                    while (reader_2.Read())
                    {
                        SubstanceView substance = new SubstanceView() { Name = Convert.ToString(reader_2.GetValue(0)), Id = Convert.ToInt32(reader_2.GetValue(1)) };
                        cbSubstancesNameDesc.Items.Add(substance);
                        cbSubstancesNameExp.Items.Add(substance);
                    }
                }
            }
        }
        private void btn_table_view_2_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Server=KIERAN; Database=DB_Descriptors_1;Trusted_Connection=True; ";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                dgvDescriptorsView.Rows.Clear();
                connection.Open();
                string selectedState = ((SubstanceView)cbSubstancesNameDesc.SelectedItem).Id.ToString();
                string query = string.Format("SELECT Substances.Id, Descriptors.Name, DescriptorsDictionary.Value FROM  Descriptors, Substances, DescriptorsDictionary WHERE Descriptors.Id = DescriptorsDictionary.DescriptorId AND Substances.Id = DescriptorsDictionary.SubstanceId AND Substances.Id = {0} AND Descriptors.Name IS NOT NULL", selectedState);
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var Id = reader.GetValue(0);
                        var Name_of_substance = reader.GetValue(1);
                        var Name_of_descriptor = reader.GetValue(2);
                        dgvDescriptorsView.Rows.Add(Id, Name_of_substance, Name_of_descriptor);
                    }
                }
            }
        }     
    }
}
