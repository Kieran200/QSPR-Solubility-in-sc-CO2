using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.CompilerServices;

namespace Interface_for_BD
{
    public partial class Equation : Form
    {
        public static List<string> LSub = new List<string>();
        public static List<string> LDesc = new List<string>();
        public static List<string> LSubName = new List<string>();
        public static List<string> LDescName = new List<string>();
        public static List<List<double>> FinalCoefListFull = new List<List<double>>();
        public static List<List<double>> ValuesFull = new List<List<double>>();
        public static List<List<double>> ValuesFullExcel = new List<List<double>>();
        public static List<double> SolubFull = new List<double>();
        public static List<double> SolubFullExcel = new List<double>();
        double solub;
        public static string equation;
        List<List<double>> eqList = new List<List<double>>();
        List<double> solubList = new List<double>();
        public static List<double> FinalCoefList = new List<double>();
        bool pow = false;

        /// <summary>
        /// ИНИЦИАЛИЗАЦИЯ
        /// </summary>
        public Equation()
        {
            InitializeComponent();
            SubAdd();
            cbSelection.Text = cbSelection.Items[4].ToString();
        }

        /// <summary>
        /// Кнопка добавления общих доступных дескрипторов в поле
        /// </summary>
        private void btnAddSubstances_Click(object sender, EventArgs e)
        {
            DescAdd();
        }

        /// <summary>
        /// Расчет уравнения в соответствии с выбранными дескрипторами при помощи множественной линейной регрессии
        /// </summary>
        private void btnCalculateEquation_Click(object sender, EventArgs e)
        {
            List<double> coefList = new List<double>();
            SqlConnection connection = new SqlConnection("Server=KIERAN; Database=DB_Descriptors_1;Trusted_Connection=True; MultipleActiveResultSets=True");
            connection.Open();
            for (int i = 0; i < clbSubstances.CheckedItems.Count; i++)
            {
                //добавляем давление, температуру и растворимость iго вещества
                string count_query = string.Format("SELECT COUNT(*) FROM Experiments, Points, Substances, Density WHERE Points.ExperimentId = Experiments.Id AND Experiments.SubstanceId = Substances.Id AND Substances.Id = {0} AND  Density.Temperature = Points.Temperature AND Density.Pressure = Points.Pressure AND Density.SubstanceId = '4791'", ((Substances)clbSubstances.CheckedItems[i]).Id);
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
                double ratio = 1;
                TranslateRatioSelections(out ratio);
                for (int k = 1; k <= count; k++)
                {
                    if (k < count * ratio)
                    {

                        List<double> Values = new List<double>();
                        string query_check = string.Format("SELECT TOP({1}) Points.Pressure, Points.Temperature, Points.Value, Density.Value FROM Experiments, Points, Substances, Density WHERE Points.ExperimentId = Experiments.Id AND Experiments.SubstanceId = Substances.Id AND Substances.Id = {0} AND  Density.Temperature = Points.Temperature AND Density.Pressure = Points.Pressure AND Density.SubstanceId = '4791' EXCEPT SELECT TOP({2}) Points.Pressure, Points.Temperature, Points.Value, Density.Value FROM Experiments, Points, Substances, Density WHERE Points.ExperimentId = Experiments.Id AND Experiments.SubstanceId = Substances.Id AND Substances.Id = {0} AND  Density.Temperature = Points.Temperature AND Density.Pressure = Points.Pressure AND Density.SubstanceId = '4791'", ((Substances)clbSubstances.CheckedItems[i]).Id, k, k - 1);
                        SqlCommand command3 = new SqlCommand(query_check, connection);
                        SqlDataReader reader3 = command3.ExecuteReader();
                        if (reader3.HasRows)
                        {
                            while (reader3.Read())
                            {
                                Values.Clear();
                                if (Convert.ToDouble(reader3.GetValue(2)) > 0.00000001)
                                {
                                    //добавляем дескрипторы для iго вещества
                                    for (int j = 0; j < clbDescriptors.CheckedItems.Count; j++)
                                    {
                                        string query = string.Format("SELECT TOP(1) DescriptorsDictionary.Value FROM  Descriptors, Substances, DescriptorsDictionary WHERE {0} = DescriptorsDictionary.DescriptorId AND {1} = DescriptorsDictionary.SubstanceId", ((Descriptors)clbDescriptors.CheckedItems[j]).Id, ((Substances)clbSubstances.CheckedItems[i]).Id);
                                        SqlCommand command4 = new SqlCommand(query, connection);
                                        SqlDataReader reader4 = command4.ExecuteReader();
                                        if (reader4.HasRows)
                                        {
                                            while (reader4.Read())
                                            {
                                                Values.Add(Convert.ToDouble(reader4.GetValue(0)));
                                            }
                                        }
                                        if (i == 0 && k == 1)
                                        {
                                            LDesc.Add(((Descriptors)clbDescriptors.CheckedItems[j]).Id.ToString());
                                            LDescName.Add(((Descriptors)clbDescriptors.CheckedItems[j]).Name.ToString());
                                        }
                                    }
                                    //добавление плотности, температуры и растворимости

                                    Values.Add(Math.Log(Convert.ToDouble(reader3.GetValue(3))));
                                    Values.Add(1 / Convert.ToDouble(reader3.GetValue(1)));
                                    Values.Add(1);
                                    solub = Math.Log((Convert.ToDouble(reader3.GetValue(2))));

                                    ValuesFull.Add(Values);
                                    SolubFull.Add(solub);

                                }
                            }
                        }
                    }
                    else
                    {
                        List<double> Values = new List<double>();
                        string query_check = string.Format("SELECT TOP({1}) Points.Pressure, Points.Temperature, Points.Value, Density.Value FROM Experiments, Points, Substances, Density WHERE Points.ExperimentId = Experiments.Id AND Experiments.SubstanceId = Substances.Id AND Substances.Id = {0} AND  Density.Temperature = Points.Temperature AND Density.Pressure = Points.Pressure AND Density.SubstanceId = '4791' EXCEPT SELECT TOP({2}) Points.Pressure, Points.Temperature, Points.Value, Density.Value FROM Experiments, Points, Substances, Density WHERE Points.ExperimentId = Experiments.Id AND Experiments.SubstanceId = Substances.Id AND Substances.Id = {0} AND  Density.Temperature = Points.Temperature AND Density.Pressure = Points.Pressure AND Density.SubstanceId = '4791'", ((Substances)clbSubstances.CheckedItems[i]).Id, k, k - 1);
                        SqlCommand command3 = new SqlCommand(query_check, connection);
                        SqlDataReader reader3 = command3.ExecuteReader();
                        if (reader3.HasRows)
                        {
                            while (reader3.Read())
                            {
                                Values.Clear();
                                if (Convert.ToDouble(reader3.GetValue(2)) > 0.00000001)
                                {
                                    //добавляем дескрипторы для iго вещества
                                    for (int j = 0; j < clbDescriptors.CheckedItems.Count; j++)
                                    {
                                        string query = string.Format("SELECT TOP(1) DescriptorsDictionary.Value FROM  Descriptors, Substances, DescriptorsDictionary WHERE {0} = DescriptorsDictionary.DescriptorId AND {1} = DescriptorsDictionary.SubstanceId", ((Descriptors)clbDescriptors.CheckedItems[j]).Id, ((Substances)clbSubstances.CheckedItems[i]).Id);
                                        SqlCommand command4 = new SqlCommand(query, connection);
                                        SqlDataReader reader4 = command4.ExecuteReader();
                                        if (reader4.HasRows)
                                        {
                                            while (reader4.Read())
                                            {
                                                Values.Add(Convert.ToDouble(reader4.GetValue(0)));
                                            }
                                        }
                                        if (i == 0 && k == 1)
                                        {
                                            LDesc.Add(((Descriptors)clbDescriptors.CheckedItems[j]).Id.ToString());
                                            LDescName.Add(((Descriptors)clbDescriptors.CheckedItems[j]).Name.ToString());
                                        }
                                    }
                                    //добавление плотности, температуры и растворимости

                                    Values.Add(Math.Log(Convert.ToDouble(reader3.GetValue(3))));
                                    Values.Add(1 / Convert.ToDouble(reader3.GetValue(1)));
                                    Values.Add(1);
                                    solub = Math.Log((Convert.ToDouble(reader3.GetValue(2))));

                                    ValuesFullExcel.Add(Values);
                                    SolubFullExcel.Add(solub);

                                }
                            }
                        }
                    }
                }
            }
            double[,] mValuesFull = new double[ValuesFull.Count, ValuesFull[0].Count];
            double[,] mSolubFull = new double[SolubFull.Count, 1];

            for (int i = 0; i < ValuesFull.Count; i++)
                for (int j = 0; j < ValuesFull[i].Count; j++)
                {
                    mValuesFull[i, j] = ValuesFull[i][j];
                }
            for (int i = 0; i < SolubFull.Count; i++)
                mSolubFull[i, 0] = SolubFull[i];

            Matrix matrixValues = new Matrix(mValuesFull);
            Matrix matrixSolub = new Matrix(mSolubFull);
            MultipleLinearRegression MLR = new MultipleLinearRegression();
            Matrix Coef = MLR.GetBCoefficientsForMatrix(matrixValues, matrixSolub);

            for (int i = 0; i < Coef.matrixBase.GetLength(0); i++)
            {
                FinalCoefList.Add(Coef.matrixBase[i, 0]);
            }

            connection.Close();
            Fin_Part();
        }


        /// <summary>
        /// Добавление финального уравнения в окно
        /// </summary>
        private void Fin_Part()
        {
            equation = "";
            if (FinalCoefList.Count > 3)
                for (int i = 0; i < FinalCoefList.Count - 3; i++)
                    equation += (Convert.ToString(FinalCoefList[i]) + " * d" + Convert.ToString(i + 1) + " + ");
            equation += (FinalCoefList[FinalCoefList.Count - 3] + " * ln(p)" + " + ");
            equation += (FinalCoefList[FinalCoefList.Count - 2] + " * 1/T");
            equation += FinalCoefList[FinalCoefList.Count - 1];
            rtbFinalEquation.Text = equation;
            FinalCoefListFull.Add(FinalCoefList);
        }
        
        /// <summary>
        /// Перенос данных в эксель
        /// </summary>
        private void btnExcelPlot_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            ExcelApp.Application.Workbooks.Add(Type.Missing);

            for (int i = 0; i < FinalCoefListFull.Count; i++)
            {
                for (int j = 0; j < FinalCoefListFull[i].Count; j++)
                {
                    ExcelApp.Cells[i + 3, j + 1] = FinalCoefListFull[i][j].ToString(new System.Globalization.CultureInfo("en-US").NumberFormat); ;
                }
            }
            ExcelApp.Cells[1, 1] = "Финальное уравнение";

            if (FinalCoefListFull.Count > 3)
                for (int j = 0; j < FinalCoefListFull[0].Count - 3; j++)
                {
                    ExcelApp.Cells[2, j + 1] = string.Format("x(d{0})", j + 1);
                    ExcelApp.Cells[6, j + 1] = string.Format("d{0}", j + 1);
                }
            ExcelApp.Cells[2, FinalCoefListFull[0].Count - 2] = "x(1/p)";
            ExcelApp.Cells[2, FinalCoefListFull[0].Count - 1] = "x(1/T)";
            ExcelApp.Cells[2, FinalCoefListFull[0].Count] = "Своб. член";
            ExcelApp.Cells[6, FinalCoefListFull[0].Count - 2] = "p";
            ExcelApp.Cells[6, FinalCoefListFull[0].Count - 1] = "1/T";
            ExcelApp.Cells[6, FinalCoefListFull[0].Count] = "Своб. член";
            ExcelApp.Cells[6, FinalCoefListFull[0].Count + 1] = "Растворимость экспериментальная";
            ExcelApp.Cells[6, FinalCoefListFull[0].Count + 2] = "Растворимость расчетная";
            ExcelApp.Cells[5, 1] = "Значения дескрипторов и растворимость:";

            Microsoft.Office.Interop.Excel.Worksheet Sheet;
            Sheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelApp.Sheets[1];

            ChartObjects xlCharts = (ChartObjects)Sheet.ChartObjects(Type.Missing);
            ChartObject myChart = (ChartObject)xlCharts.Add(110, 0, 350, 250);
            Chart chart = myChart.Chart;

            SeriesCollection seriesCollection = (SeriesCollection)chart.SeriesCollection(Type.Missing);
            Series series = seriesCollection.NewSeries();

            double count_solub = 0;

            for (int i = 0; i < ValuesFullExcel.Count; i++)
            {
                series.ClearFormats();
                for (int j = 0; j < ValuesFullExcel[0].Count; j++)
                {
                    ExcelApp.Cells[i + 7, j + 1] = ValuesFullExcel[i][j].ToString(new System.Globalization.CultureInfo("en-US").NumberFormat);
                    count_solub += ValuesFullExcel[i][j] * FinalCoefListFull[0][j];
                }

                ExcelApp.Cells[i + 7, ValuesFullExcel[0].Count + 2] = count_solub.ToString(new System.Globalization.CultureInfo("en-US").NumberFormat);
                count_solub = 0;
                ExcelApp.Cells[i + 7, ValuesFullExcel[0].Count + 1] = SolubFullExcel[i].ToString(new System.Globalization.CultureInfo("en-US").NumberFormat);
            }
            ExcelApp.Visible = true;
        }

        /// <summary>
        /// Класс, используемый для создание чек-лист боксов
        /// </summary>
        class Descriptors
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public override string ToString()
            {
                return Name;
            }
        }
        /// <summary>
        /// Класс, используемый для создание чек-лист боксов
        /// </summary>
        class Substances
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public override string ToString()
            {
                return Name;
            }
        }

        public RichTextBox getRichTextBox()
        {
            return rtbFinalEquation;
        }

        /// <summary>
        /// Очищает список выбранных веществ
        /// </summary>
        private void btnClearSublist_Click(object sender, EventArgs e)
        {
            clbSubstances.Items.Clear();
            SubAdd();
            clbSubstances.ClearSelected();
            LSub.Clear();
            LSubName.Clear();
            clbDescriptors.Items.Clear();
            DescClear();
        }

        /// <summary>
        /// Очищает список выбранных дескрипторов без удаления выбранных веществ
        /// </summary>
        private void btnClearDesclist_Click(object sender, EventArgs e)
        {
            DescClear();
            if (clbSubstances.CheckedItems != null) 
                DescAdd();
        }

        /// <summary>
        /// Очищает список выбранных дескрипторов
        /// </summary>
        public void DescClear()
        {
            //очистка от дескрипторов и расчетных данных
            clbDescriptors.Items.Clear();
            clbDescriptors.ClearSelected();
            ValuesFull.Clear();
            SolubFull.Clear();
            ValuesFullExcel.Clear();
            SolubFullExcel.Clear();
            FinalCoefList.Clear();
            FinalCoefListFull.Clear();
            rtbFinalEquation.Clear();
        }
        /// <summary>
        /// Добавление дескрипторов в поле
        /// </summary>
        public void DescAdd()
        {
            SqlConnection connection = new SqlConnection("Server=KIERAN; Database=DB_Descriptors_1;Trusted_Connection=True; ");
            connection.Open();
            //сбор всех общих дескрипторов выбранных веществ
            List<List<string>> desc_List = new List<List<string>>();
            for (int i = 0; i < clbSubstances.CheckedItems.Count; i++)
            {
                List<string> desc = new List<string>();
                desc_List.Add(desc);
                LSub.Add(((Substances)clbSubstances.CheckedItems[i]).Id.ToString());
                LSubName.Add(((Substances)clbSubstances.CheckedItems[i]).Name.ToString());
                string query_for_desc = string.Format("SELECT DISTINCT Descriptors.Id FROM Descriptors, DescriptorsDictionary, Substances, Points, Experiments WHERE Descriptors.Id = DescriptorsDictionary.DescriptorId AND Substances.Id = DescriptorsDictionary.SubstanceId AND Substances.Id = {0} AND DescriptorsDictionary.Value != 0 AND Points.Value != 0 AND  Points.ExperimentId = Experiments.Id AND Experiments.SubstanceId = Substances.Id AND Descriptors.Name IS NOT NULL", ((Substances)clbSubstances.CheckedItems[i]).Id.ToString());
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
            //добавление дескрипторов в список
            for (int i = 0; i < desc_List[0].Count; i++)
            {
                string query_for_desc = string.Format("SELECT DISTINCT Descriptors.Name, Descriptors.Marker \r\n\tFROM Descriptors, DescriptorsDictionary\r\n\tWHERE Descriptors.Id = DescriptorsDictionary.DescriptorId AND\r\n\tDescriptorsDictionary.DescriptorId = {0}", desc_List[0][i]);
                SqlCommand command2 = new SqlCommand(query_for_desc, connection);
                SqlDataReader reader2 = command2.ExecuteReader();

                if (reader2.HasRows)
                {
                    while (reader2.Read())
                    {
                        name = Convert.ToString(reader2.GetValue(0));
                        name += " - ";
                        name += Convert.ToString(reader2.GetValue(1));
                    }
                }
                Descriptors desc = new Descriptors() { Id = Convert.ToInt32(desc_List[0][i]), Name = name };
                clbDescriptors.Items.Add(desc);
                reader2.Close();
            }
            connection.Close();
            desc_List.Clear();
        }

        /// <summary>
        /// Добавление веществ в поле
        /// </summary>
        public void SubAdd()
        {
            SqlConnection connection = new SqlConnection("Server=KIERAN; Database=DB_Descriptors_1;Trusted_Connection=True; ");
            connection.Open();
            string query = string.Format("SELECT DISTINCT Substances.Name, Substances.Id\r\nFROM Experiments, Points, Substances, Density, DescriptorsDictionary, Descriptors\r\nWHERE Points.ExperimentId = Experiments.Id AND \r\nExperiments.SubstanceId = Substances.Id AND \r\nDensity.Temperature = Points.Temperature AND \r\nDensity.Pressure = Points.Pressure AND Density.SubstanceId = '4791' AND\r\nDescriptors.Id = DescriptorsDictionary.DescriptorId AND\r\nDescriptorsDictionary.SubstanceId = Substances.Id AND Substances.Id = DescriptorsDictionary.SubstanceId AND \r\nDescriptorsDictionary.Value != 0 AND\r\nPoints.Value != 0 AND  \r\nPoints.ExperimentId = Experiments.Id AND  \r\nExperiments.SubstanceId = Substances.Id\r\n");
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Substances sub = new Substances() { Id = Convert.ToInt32(reader.GetValue(1)), Name = Convert.ToString(reader.GetValue(0)) };
                    clbSubstances.Items.Add(sub);
                }
            }
            reader.Close();
            connection.Close();
        }
        public void TranslateRatioSelections(out double ratio)
        { 
            ratio = Convert.ToDouble(cbSelection.Text.Substring(0, cbSelection.Text.Length - 3))/100;
        }
    }
}
