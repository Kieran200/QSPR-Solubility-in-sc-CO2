
namespace Interface_for_BD
{
    partial class Main_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Open_BD = new System.Windows.Forms.Button();
            this.dB_Descriptors_1DataSet = new Interface_for_BD.DB_Descriptors_1DataSet();
            this.descriptorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptorsTableAdapter = new Interface_for_BD.DB_Descriptors_1DataSetTableAdapters.DescriptorsTableAdapter();
            this.Btn_2 = new System.Windows.Forms.Button();
            this.btnCluster = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Descriptors_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Open_BD
            // 
            this.Open_BD.BackColor = System.Drawing.Color.AliceBlue;
            this.Open_BD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Open_BD.Location = new System.Drawing.Point(147, 27);
            this.Open_BD.Name = "Open_BD";
            this.Open_BD.Size = new System.Drawing.Size(174, 56);
            this.Open_BD.TabIndex = 0;
            this.Open_BD.Text = "Открыть базу данных";
            this.Open_BD.UseVisualStyleBackColor = false;
            this.Open_BD.Click += new System.EventHandler(this.Open_BD_Click);
            // 
            // dB_Descriptors_1DataSet
            // 
            this.dB_Descriptors_1DataSet.DataSetName = "DB_Descriptors_1DataSet";
            this.dB_Descriptors_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // descriptorsTableAdapter
            // 
            this.descriptorsTableAdapter.ClearBeforeFill = true;
            // 
            // Btn_2
            // 
            this.Btn_2.BackColor = System.Drawing.Color.AliceBlue;
            this.Btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_2.Location = new System.Drawing.Point(147, 101);
            this.Btn_2.Name = "Btn_2";
            this.Btn_2.Size = new System.Drawing.Size(174, 56);
            this.Btn_2.TabIndex = 1;
            this.Btn_2.Text = "Работа с уравнением растворимости";
            this.Btn_2.UseVisualStyleBackColor = false;
            this.Btn_2.Click += new System.EventHandler(this.Btn_2_Click);
            // 
            // btnCluster
            // 
            this.btnCluster.BackColor = System.Drawing.Color.AliceBlue;
            this.btnCluster.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCluster.Location = new System.Drawing.Point(147, 177);
            this.btnCluster.Name = "btnCluster";
            this.btnCluster.Size = new System.Drawing.Size(174, 56);
            this.btnCluster.TabIndex = 2;
            this.btnCluster.Text = "Кластеризация";
            this.btnCluster.UseVisualStyleBackColor = false;
            this.btnCluster.Click += new System.EventHandler(this.btnCluster_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(476, 266);
            this.Controls.Add(this.btnCluster);
            this.Controls.Add(this.Btn_2);
            this.Controls.Add(this.Open_BD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Main_Form";
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_Descriptors_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptorsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Open_BD;
        private DB_Descriptors_1DataSet dB_Descriptors_1DataSet;
        private System.Windows.Forms.BindingSource descriptorsBindingSource;
        private DB_Descriptors_1DataSetTableAdapters.DescriptorsTableAdapter descriptorsTableAdapter;
        private System.Windows.Forms.Button Btn_2;
        private System.Windows.Forms.Button btnCluster;
    }
}

