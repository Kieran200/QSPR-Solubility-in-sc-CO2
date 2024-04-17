
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
            this.cLB_sub = new System.Windows.Forms.CheckedListBox();
            this.cLB_Desc = new System.Windows.Forms.CheckedListBox();
            this.btnAddSubstances = new System.Windows.Forms.Button();
            this.but_eqs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rTB_Fin_Eq = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Plot = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_clear_sublist = new System.Windows.Forms.Button();
            this.btn_clear_desclist = new System.Windows.Forms.Button();
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
            // cLB_sub
            // 
            this.cLB_sub.AllowDrop = true;
            this.cLB_sub.BackColor = System.Drawing.Color.GhostWhite;
            this.cLB_sub.CheckOnClick = true;
            this.cLB_sub.FormattingEnabled = true;
            this.cLB_sub.Items.AddRange(new object[] {
            ""});
            this.cLB_sub.Location = new System.Drawing.Point(43, 25);
            this.cLB_sub.Name = "cLB_sub";
            this.cLB_sub.Size = new System.Drawing.Size(371, 191);
            this.cLB_sub.TabIndex = 40;
            // 
            // cLB_Desc
            // 
            this.cLB_Desc.AllowDrop = true;
            this.cLB_Desc.BackColor = System.Drawing.Color.GhostWhite;
            this.cLB_Desc.CheckOnClick = true;
            this.cLB_Desc.FormattingEnabled = true;
            this.cLB_Desc.Items.AddRange(new object[] {
            ""});
            this.cLB_Desc.Location = new System.Drawing.Point(438, 25);
            this.cLB_Desc.Name = "cLB_Desc";
            this.cLB_Desc.Size = new System.Drawing.Size(369, 191);
            this.cLB_Desc.TabIndex = 41;
            this.cLB_Desc.Tag = "";
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
            // but_eqs
            // 
            this.but_eqs.BackColor = System.Drawing.Color.AliceBlue;
            this.but_eqs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.but_eqs.Location = new System.Drawing.Point(438, 235);
            this.but_eqs.Name = "but_eqs";
            this.but_eqs.Size = new System.Drawing.Size(179, 43);
            this.but_eqs.TabIndex = 45;
            this.but_eqs.Text = "Рассчитать уравнение";
            this.but_eqs.UseVisualStyleBackColor = false;
            this.but_eqs.Click += new System.EventHandler(this.but_eqs_Click);
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
            // rTB_Fin_Eq
            // 
            this.rTB_Fin_Eq.Location = new System.Drawing.Point(43, 316);
            this.rTB_Fin_Eq.Name = "rTB_Fin_Eq";
            this.rTB_Fin_Eq.Size = new System.Drawing.Size(764, 91);
            this.rTB_Fin_Eq.TabIndex = 49;
            this.rTB_Fin_Eq.Text = "";
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
            // Btn_Plot
            // 
            this.Btn_Plot.BackColor = System.Drawing.Color.AliceBlue;
            this.Btn_Plot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Plot.Location = new System.Drawing.Point(271, 413);
            this.Btn_Plot.Name = "Btn_Plot";
            this.Btn_Plot.Size = new System.Drawing.Size(271, 40);
            this.Btn_Plot.TabIndex = 51;
            this.Btn_Plot.Text = "График отклонения результатов";
            this.Btn_Plot.UseVisualStyleBackColor = false;
            this.Btn_Plot.Click += new System.EventHandler(this.Btn_Plot_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(414, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 53;
            // 
            // btn_clear_sublist
            // 
            this.btn_clear_sublist.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_clear_sublist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clear_sublist.Location = new System.Drawing.Point(235, 235);
            this.btn_clear_sublist.Name = "btn_clear_sublist";
            this.btn_clear_sublist.Size = new System.Drawing.Size(179, 43);
            this.btn_clear_sublist.TabIndex = 54;
            this.btn_clear_sublist.Text = "Очистить список веществ";
            this.btn_clear_sublist.UseVisualStyleBackColor = false;
            this.btn_clear_sublist.Click += new System.EventHandler(this.btn_clear_sublist_Click);
            // 
            // btn_clear_desclist
            // 
            this.btn_clear_desclist.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_clear_desclist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clear_desclist.Location = new System.Drawing.Point(628, 235);
            this.btn_clear_desclist.Name = "btn_clear_desclist";
            this.btn_clear_desclist.Size = new System.Drawing.Size(179, 43);
            this.btn_clear_desclist.TabIndex = 55;
            this.btn_clear_desclist.Text = "Очистить список дескрипторов";
            this.btn_clear_desclist.UseVisualStyleBackColor = false;
            this.btn_clear_desclist.Click += new System.EventHandler(this.btn_clear_desclist_Click);
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
            this.Controls.Add(this.btn_clear_desclist);
            this.Controls.Add(this.btn_clear_sublist);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Btn_Plot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rTB_Fin_Eq);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_eqs);
            this.Controls.Add(this.btnAddSubstances);
            this.Controls.Add(this.cLB_Desc);
            this.Controls.Add(this.cLB_sub);
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
        private System.Windows.Forms.CheckedListBox cLB_sub;
        private System.Windows.Forms.CheckedListBox cLB_Desc;
        private System.Windows.Forms.Button btnAddSubstances;
        private System.Windows.Forms.Button but_eqs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rTB_Fin_Eq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_Plot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_clear_sublist;
        private System.Windows.Forms.Button btn_clear_desclist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSelection;
    }
}