using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;



namespace Interface_for_BD
{
    internal class Density
    {
        /// <summary>
        /// Получение значения плотности из базы данных по значениям давления и температуры  
        /// </summary>
        public void GetDensity(object pressure, object temperature, double sub_id, out bool empty, out double density)
        {
            empty = false;
            density = 0;    

            string ConnectionString = "Server=KIERAN; Database=DB_Descriptors_1;Trusted_Connection=True; ";
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            string query = string.Format("SELECT TOP(1) Density.Value\r\nFROM Density, Substances, Experiments, Points\r\nWHERE\r\nDensity.SubstanceId = '4791' AND\r\nPoints.Temperature = Density.Temperature AND\r\nPoints.Pressure = Density.Pressure AND\r\nPoints.ExperimentId = Experiments.Id AND\r\nPoints.Temperature = '{0}' AND\r\nPoints.Pressure = '{1}' AND\r\nSubstances.Id = '{2}'", temperature, pressure, sub_id);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    density = Convert.ToDouble(reader.GetValue(0));
                }
            }
            else
                empty = true;
            reader.Close();
        }
    }
}
