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
    partial class Full_Table
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
            this.Full_Table_View = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_of_descriptor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_table_view = new System.Windows.Forms.Button();
            this.substancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_Descriptors_1DataSet = new Interface_for_BD.DB_Descriptors_1DataSet();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_table_view_2 = new System.Windows.Forms.Button();
            this.cb_sub_name_2 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Exp_view = new System.Windows.Forms.DataGridView();
            this.Exp_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Solubility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Temperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pressure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_sub_name = new System.Windows.Forms.ComboBox();
            this.substancesTableAdapter = new Interface_for_BD.DB_Descriptors_1DataSetTableAdapters.SubstancesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Full_Table_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.substancesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Descriptors_1DataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exp_view)).BeginInit();
            this.SuspendLayout();
            // 
            // Full_Table_View
            // 
            this.Full_Table_View.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.Full_Table_View.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Full_Table_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Full_Table_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name_of_descriptor,
            this.Value});
            this.Full_Table_View.Location = new System.Drawing.Point(6, 6);
            this.Full_Table_View.Name = "Full_Table_View";
            this.Full_Table_View.RowHeadersWidth = 51;
            this.Full_Table_View.RowTemplate.Height = 24;
            this.Full_Table_View.Size = new System.Drawing.Size(756, 342);
            this.Full_Table_View.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // Name_of_descriptor
            // 
            this.Name_of_descriptor.HeaderText = "Name of descriptor";
            this.Name_of_descriptor.MinimumWidth = 6;
            this.Name_of_descriptor.Name = "Name_of_descriptor";
            this.Name_of_descriptor.Width = 125;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.MinimumWidth = 6;
            this.Value.Name = "Value";
            this.Value.Width = 125;
            // 
            // btn_table_view
            // 
            this.btn_table_view.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_table_view.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_table_view.Location = new System.Drawing.Point(6, 355);
            this.btn_table_view.Name = "btn_table_view";
            this.btn_table_view.Size = new System.Drawing.Size(164, 47);
            this.btn_table_view.TabIndex = 1;
            this.btn_table_view.Text = "Показать значения растворимости";
            this.btn_table_view.UseVisualStyleBackColor = false;
            this.btn_table_view.Click += new System.EventHandler(this.btn_table_view_Click);
            // 
            // dB_Descriptors_1DataSet
            // 
            this.dB_Descriptors_1DataSet.DataSetName = "DB_Descriptors_1DataSet";
            this.dB_Descriptors_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 437);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_table_view_2);
            this.tabPage1.Controls.Add(this.cb_sub_name_2);
            this.tabPage1.Controls.Add(this.Full_Table_View);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 408);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Значения дескрипторов";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_table_view_2
            // 
            this.btn_table_view_2.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_table_view_2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_table_view_2.Location = new System.Drawing.Point(6, 355);
            this.btn_table_view_2.Name = "btn_table_view_2";
            this.btn_table_view_2.Size = new System.Drawing.Size(164, 47);
            this.btn_table_view_2.TabIndex = 5;
            this.btn_table_view_2.Text = "Показать характеристики";
            this.btn_table_view_2.UseVisualStyleBackColor = false;
            this.btn_table_view_2.Click += new System.EventHandler(this.btn_table_view_2_Click);
            // 
            // cb_sub_name_2
            // 
            this.cb_sub_name_2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cb_sub_name_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sub_name_2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_sub_name_2.FormattingEnabled = true;
            this.cb_sub_name_2.Location = new System.Drawing.Point(231, 366);
            this.cb_sub_name_2.Name = "cb_sub_name_2";
            this.cb_sub_name_2.Size = new System.Drawing.Size(360, 24);
            this.cb_sub_name_2.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Exp_view);
            this.tabPage2.Controls.Add(this.cb_sub_name);
            this.tabPage2.Controls.Add(this.btn_table_view);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 408);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Экспериментальные точки";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Exp_view
            // 
            this.Exp_view.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.Exp_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Exp_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Exp_Id,
            this.Solubility,
            this.Temperature,
            this.Pressure});
            this.Exp_view.Location = new System.Drawing.Point(6, 6);
            this.Exp_view.Name = "Exp_view";
            this.Exp_view.RowHeadersWidth = 51;
            this.Exp_view.RowTemplate.Height = 24;
            this.Exp_view.Size = new System.Drawing.Size(756, 342);
            this.Exp_view.TabIndex = 0;
            // 
            // Exp_Id
            // 
            this.Exp_Id.HeaderText = "Exp id";
            this.Exp_Id.MinimumWidth = 6;
            this.Exp_Id.Name = "Exp_Id";
            this.Exp_Id.Width = 125;
            // 
            // Solubility
            // 
            this.Solubility.HeaderText = "Solubility";
            this.Solubility.MinimumWidth = 6;
            this.Solubility.Name = "Solubility";
            this.Solubility.Width = 125;
            // 
            // Temperature
            // 
            this.Temperature.HeaderText = "Temperature";
            this.Temperature.MinimumWidth = 6;
            this.Temperature.Name = "Temperature";
            this.Temperature.Width = 125;
            // 
            // Pressure
            // 
            this.Pressure.HeaderText = "Pressure";
            this.Pressure.MinimumWidth = 6;
            this.Pressure.Name = "Pressure";
            this.Pressure.Width = 125;
            // 
            // cb_sub_name
            // 
            this.cb_sub_name.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cb_sub_name.DisplayMember = "Name";
            this.cb_sub_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sub_name.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_sub_name.FormattingEnabled = true;
            this.cb_sub_name.Location = new System.Drawing.Point(231, 366);
            this.cb_sub_name.Name = "cb_sub_name";
            this.cb_sub_name.Size = new System.Drawing.Size(360, 24);
            this.cb_sub_name.TabIndex = 3;
            this.cb_sub_name.ValueMember = "Id";
            // 
            // substancesTableAdapter
            // 
            this.substancesTableAdapter.ClearBeforeFill = true;
            // 
            // Full_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Full_Table";
            this.Text = "База данных";
            this.Load += new System.EventHandler(this.Full_Table_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Full_Table_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.substancesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Descriptors_1DataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Exp_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Full_Table_View;
        private Button btn_table_view;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Name_of_descriptor;
        private DataGridViewTextBoxColumn Value;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView Exp_view;
        private DataGridViewTextBoxColumn Exp_Id;
        private DB_Descriptors_1DataSet dB_Descriptors_1DataSet;
        private BindingSource substancesBindingSource;
        private DB_Descriptors_1DataSetTableAdapters.SubstancesTableAdapter substancesTableAdapter;
        private DataGridViewTextBoxColumn Solubility;
        private DataGridViewTextBoxColumn Temperature;
        private DataGridViewTextBoxColumn Pressure;
        private Button btn_table_view_2;
        private ComboBox cb_sub_name_2;
        private ComboBox cb_sub_name;
    }
}