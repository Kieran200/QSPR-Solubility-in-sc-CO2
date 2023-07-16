
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
            this.but_sub = new System.Windows.Forms.Button();
            this.rTB_Eqs = new System.Windows.Forms.RichTextBox();
            this.but_eqs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rTB_Fin_Eq = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Plot = new System.Windows.Forms.Button();
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
            this.cLB_sub.Size = new System.Drawing.Size(328, 191);
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
            this.cLB_Desc.Location = new System.Drawing.Point(43, 319);
            this.cLB_Desc.Name = "cLB_Desc";
            this.cLB_Desc.Size = new System.Drawing.Size(328, 191);
            this.cLB_Desc.TabIndex = 41;
            this.cLB_Desc.Tag = "";
            // 
            // but_sub
            // 
            this.but_sub.BackColor = System.Drawing.Color.AliceBlue;
            this.but_sub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.but_sub.Location = new System.Drawing.Point(110, 235);
            this.but_sub.Name = "but_sub";
            this.but_sub.Size = new System.Drawing.Size(179, 28);
            this.but_sub.TabIndex = 42;
            this.but_sub.Text = "Добавить вещества";
            this.but_sub.UseVisualStyleBackColor = false;
            this.but_sub.Click += new System.EventHandler(this.but_sub_Click);
            // 
            // rTB_Eqs
            // 
            this.rTB_Eqs.BackColor = System.Drawing.Color.GhostWhite;
            this.rTB_Eqs.Location = new System.Drawing.Point(447, 25);
            this.rTB_Eqs.Name = "rTB_Eqs";
            this.rTB_Eqs.Size = new System.Drawing.Size(454, 306);
            this.rTB_Eqs.TabIndex = 44;
            this.rTB_Eqs.Text = "";
            // 
            // but_eqs
            // 
            this.but_eqs.BackColor = System.Drawing.Color.AliceBlue;
            this.but_eqs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.but_eqs.Location = new System.Drawing.Point(447, 507);
            this.but_eqs.Name = "but_eqs";
            this.but_eqs.Size = new System.Drawing.Size(212, 50);
            this.but_eqs.TabIndex = 45;
            this.but_eqs.Text = "Рассчитать уравнение";
            this.but_eqs.UseVisualStyleBackColor = false;
            this.but_eqs.Click += new System.EventHandler(this.but_eqs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 300);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 16);
            this.label3.TabIndex = 48;
            this.label3.Text = "Общий список уравнений";
            // 
            // rTB_Fin_Eq
            // 
            this.rTB_Fin_Eq.Location = new System.Drawing.Point(447, 382);
            this.rTB_Fin_Eq.Name = "rTB_Fin_Eq";
            this.rTB_Fin_Eq.Size = new System.Drawing.Size(454, 91);
            this.rTB_Fin_Eq.TabIndex = 49;
            this.rTB_Fin_Eq.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 16);
            this.label4.TabIndex = 50;
            this.label4.Text = "Финальное уравнение";
            // 
            // Btn_Plot
            // 
            this.Btn_Plot.BackColor = System.Drawing.Color.AliceBlue;
            this.Btn_Plot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Plot.Location = new System.Drawing.Point(689, 507);
            this.Btn_Plot.Name = "Btn_Plot";
            this.Btn_Plot.Size = new System.Drawing.Size(212, 50);
            this.Btn_Plot.TabIndex = 51;
            this.Btn_Plot.Text = "График отклонения результатов";
            this.Btn_Plot.UseVisualStyleBackColor = false;
            this.Btn_Plot.Click += new System.EventHandler(this.Btn_Plot_Click);
            // 
            // Equation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(955, 569);
            this.Controls.Add(this.Btn_Plot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rTB_Fin_Eq);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_eqs);
            this.Controls.Add(this.rTB_Eqs);
            this.Controls.Add(this.but_sub);
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
        private System.Windows.Forms.Button but_sub;
        private System.Windows.Forms.RichTextBox rTB_Eqs;
        private System.Windows.Forms.Button but_eqs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rTB_Fin_Eq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_Plot;
    }
}