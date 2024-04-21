
namespace Interface_for_BD
{
    partial class Equation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.substancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_Descriptors_1DataSet = new Interface_for_BD.DB_Descriptors_1DataSet();
            this.substancesTableAdapter = new Interface_for_BD.DB_Descriptors_1DataSetTableAdapters.SubstancesTableAdapter();
            this.clbSubstances = new System.Windows.Forms.CheckedListBox();
            this.clbDescriptors = new System.Windows.Forms.CheckedListBox();
            this.btnAddSubstances = new System.Windows.Forms.Button();
            this.btnCalculateEquation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbFinalEquation = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExcelPlot = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnСlearSublist = new System.Windows.Forms.Button();
            this.btnClearDesclist = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSelection = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.substancesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Descriptors_1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // substancesBindingSource
            // 
            this.substancesBindingSource.DataMember = "Substances";
            this.substancesBindingSource.DataSource = this.dB_Descriptors_1DataSet;
            // 
            // dB_Descriptors_1DataSet
            // 
            this.dB_Descriptors_1DataSet.DataSetName = "DB_Descriptors_1DataSet";
            this.dB_Descriptors_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // substancesTableAdapter
            // 
            this.substancesTableAdapter.ClearBeforeFill = true;
            // 
            // clbSubstances
            // 
            this.clbSubstances.AllowDrop = true;
            this.clbSubstances.BackColor = System.Drawing.Color.GhostWhite;
            this.clbSubstances.CheckOnClick = true;
            this.clbSubstances.FormattingEnabled = true;
            this.clbSubstances.Items.AddRange(new object[] {
            ""});
            this.clbSubstances.Location = new System.Drawing.Point(43, 25);
            this.clbSubstances.Name = "clbSubstances";
            this.clbSubstances.Size = new System.Drawing.Size(371, 191);
            this.clbSubstances.TabIndex = 40;
            // 
            // clbDescriptors
            // 
            this.clbDescriptors.AllowDrop = true;
            this.clbDescriptors.BackColor = System.Drawing.Color.GhostWhite;
            this.clbDescriptors.CheckOnClick = true;
            this.clbDescriptors.FormattingEnabled = true;
            this.clbDescriptors.Items.AddRange(new object[] {
            ""});
            this.clbDescriptors.Location = new System.Drawing.Point(438, 25);
            this.clbDescriptors.Name = "clbDescriptors";
            this.clbDescriptors.Size = new System.Drawing.Size(369, 191);
            this.clbDescriptors.TabIndex = 41;
            this.clbDescriptors.Tag = "";
            // 
            // btnAddSubstances
            // 
            this.btnAddSubstances.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAddSubstances.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddSubstances.Location = new System.Drawing.Point(43, 235);
            this.btnAddSubstances.Name = "btnAddSubstances";
            this.btnAddSubstances.Size = new System.Drawing.Size(179, 43);
            this.btnAddSubstances.TabIndex = 42;
            this.btnAddSubstances.Text = "Добавить вещества";
            this.btnAddSubstances.UseVisualStyleBackColor = false;
            this.btnAddSubstances.Click += new System.EventHandler(this.btnAddSubstances_Click);
            // 
            // btnCalculateEquation
            // 
            this.btnCalculateEquation.BackColor = System.Drawing.Color.AliceBlue;
            this.btnCalculateEquation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalculateEquation.Location = new System.Drawing.Point(438, 235);
            this.btnCalculateEquation.Name = "btnCalculateEquation";
            this.btnCalculateEquation.Size = new System.Drawing.Size(179, 43);
            this.btnCalculateEquation.TabIndex = 45;
            this.btnCalculateEquation.Text = "Рассчитать уравнение";
            this.btnCalculateEquation.UseVisualStyleBackColor = false;
            this.btnCalculateEquation.Click += new System.EventHandler(this.btnCalculateEquation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "Выбор дескрипторов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "Выбор веществ";
            // 
            // rtbFinalEquation
            // 
            this.rtbFinalEquation.Location = new System.Drawing.Point(43, 316);
            this.rtbFinalEquation.Name = "rtbFinalEquation";
            this.rtbFinalEquation.Size = new System.Drawing.Size(764, 91);
            this.rtbFinalEquation.TabIndex = 49;
            this.rtbFinalEquation.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 16);
            this.label4.TabIndex = 50;
            this.label4.Text = "Финальное уравнение";
            // 
            // btnExcelPlot
            // 
            this.btnExcelPlot.BackColor = System.Drawing.Color.AliceBlue;
            this.btnExcelPlot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcelPlot.Location = new System.Drawing.Point(271, 413);
            this.btnExcelPlot.Name = "btnExcelPlot";
            this.btnExcelPlot.Size = new System.Drawing.Size(271, 40);
            this.btnExcelPlot.TabIndex = 51;
            this.btnExcelPlot.Text = "График отклонения результатов";
            this.btnExcelPlot.UseVisualStyleBackColor = false;
            this.btnExcelPlot.Click += new System.EventHandler(this.btnExcelPlot_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(414, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 53;
            // 
            // btnСlearSublist
            // 
            this.btnСlearSublist.BackColor = System.Drawing.Color.AliceBlue;
            this.btnСlearSublist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnСlearSublist.Location = new System.Drawing.Point(235, 235);
            this.btnСlearSublist.Name = "btnСlearSublist";
            this.btnСlearSublist.Size = new System.Drawing.Size(179, 43);
            this.btnСlearSublist.TabIndex = 54;
            this.btnСlearSublist.Text = "Очистить список веществ";
            this.btnСlearSublist.UseVisualStyleBackColor = false;
            this.btnСlearSublist.Click += new System.EventHandler(this.btnClearSublist_Click);
            // 
            // btnClearDesclist
            // 
            this.btnClearDesclist.BackColor = System.Drawing.Color.AliceBlue;
            this.btnClearDesclist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearDesclist.Location = new System.Drawing.Point(628, 235);
            this.btnClearDesclist.Name = "btnClearDesclist";
            this.btnClearDesclist.Size = new System.Drawing.Size(179, 43);
            this.btnClearDesclist.TabIndex = 55;
            this.btnClearDesclist.Text = "Очистить список дескрипторов";
            this.btnClearDesclist.UseVisualStyleBackColor = false;
            this.btnClearDesclist.Click += new System.EventHandler(this.btnClearDesclist_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 16);
            this.label3.TabIndex = 57;
            this.label3.Text = "Соотношение обучающая/тестовая выборка";
            // 
            // cbSelection
            // 
            this.cbSelection.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbSelection.FormattingEnabled = true;
            this.cbSelection.Items.AddRange(new object[] {
            "90/10",
            "80/20",
            "70/30",
            "60/40",
            "50/50",
            "40/60",
            "30/70",
            "20/80",
            "10/90"});
            this.cbSelection.Location = new System.Drawing.Point(43, 494);
            this.cbSelection.Name = "cbSelection";
            this.cbSelection.Size = new System.Drawing.Size(114, 24);
            this.cbSelection.TabIndex = 58;
            // 
            // Equation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(858, 569);
            this.Controls.Add(this.cbSelection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClearDesclist);
            this.Controls.Add(this.btnСlearSublist);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnExcelPlot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtbFinalEquation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculateEquation);
            this.Controls.Add(this.btnAddSubstances);
            this.Controls.Add(this.clbDescriptors);
            this.Controls.Add(this.clbSubstances);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Equation";
            this.Text = "Уравнение растворимости";
            ((System.ComponentModel.ISupportInitialize)(this.substancesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Descriptors_1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DB_Descriptors_1DataSet dB_Descriptors_1DataSet;
        private System.Windows.Forms.BindingSource substancesBindingSource;
        private DB_Descriptors_1DataSetTableAdapters.SubstancesTableAdapter substancesTableAdapter;
        private System.Windows.Forms.CheckedListBox clbSubstances;
        private System.Windows.Forms.CheckedListBox clbDescriptors;
        private System.Windows.Forms.Button btnAddSubstances;
        private System.Windows.Forms.Button btnCalculateEquation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbFinalEquation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExcelPlot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnСlearSublist;
        private System.Windows.Forms.Button btnClearDesclist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSelection;
    }
}