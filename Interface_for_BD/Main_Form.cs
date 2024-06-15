using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Interface_for_BD
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Open_BD_Click(object sender, EventArgs e)
        {
            Full_Table full_table = new Full_Table();
            full_table.Show();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_Descriptors_1DataSet.Descriptors". При необходимости она может быть перемещена или удалена.
            //this.descriptorsTableAdapter.Fill(this.dB_Descriptors_1DataSet.Descriptors);
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            Equation eq = new Equation();
            eq.Show();
        }

        private void btnCluster_Click(object sender, EventArgs e)
        {
            frmCluster cluster = new frmCluster();
            cluster.Show();
        }
    }
}
