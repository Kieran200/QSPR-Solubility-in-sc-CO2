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
            this.dgvDescriptorsView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_of_descriptor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTableView = new System.Windows.Forms.Button();
            this.substancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_Descriptors_1DataSet = new Interface_for_BD.DB_Descriptors_1DataSet();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnViewCharacteristics = new System.Windows.Forms.Button();
            this.cbSubstancesNameDesc = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvExperimentsView = new System.Windows.Forms.DataGridView();
            this.Exp_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Solubility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Temperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pressure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbSubstancesNameExp = new System.Windows.Forms.ComboBox();
            this.Enter_Data = new System.Windows.Forms.TabPage();
            this.substancesTableAdapter = new Interface_for_BD.DB_Descriptors_1DataSetTableAdapters.SubstancesTableAdapter();
            this.dgvEnterData = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbSubstancesNameEntrerData = new System.Windows.Forms.ComboBox();
            this.btnEnterData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescriptorsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.substancesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Descriptors_1DataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExperimentsView)).BeginInit();
            this.Enter_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnterData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDescriptorsView
            // 
            this.dgvDescriptorsView.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvDescriptorsView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDescriptorsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDescriptorsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name_of_descriptor,
            this.Value});
            this.dgvDescriptorsView.Location = new System.Drawing.Point(6, 6);
            this.dgvDescriptorsView.Name = "dgvDescriptorsView";
            this.dgvDescriptorsView.RowHeadersWidth = 51;
            this.dgvDescriptorsView.RowTemplate.Height = 24;
            this.dgvDescriptorsView.Size = new System.Drawing.Size(756, 342);
            this.dgvDescriptorsView.TabIndex = 0;
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
            // btnTableView
            // 
            this.btnTableView.BackColor = System.Drawing.Color.AliceBlue;
            this.btnTableView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTableView.Location = new System.Drawing.Point(6, 355);
            this.btnTableView.Name = "btnTableView";
            this.btnTableView.Size = new System.Drawing.Size(164, 47);
            this.btnTableView.TabIndex = 1;
            this.btnTableView.Text = "Показать значения растворимости";
            this.btnTableView.UseVisualStyleBackColor = false;
            this.btnTableView.Click += new System.EventHandler(this.btn_table_view_Click);
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
            this.tabControl1.Controls.Add(this.Enter_Data);
            this.tabControl1.Location = new System.Drawing.Point(12, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 437);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnViewCharacteristics);
            this.tabPage1.Controls.Add(this.cbSubstancesNameDesc);
            this.tabPage1.Controls.Add(this.dgvDescriptorsView);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 408);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Значения дескрипторов";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnViewCharacteristics
            // 
            this.btnViewCharacteristics.BackColor = System.Drawing.Color.AliceBlue;
            this.btnViewCharacteristics.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewCharacteristics.Location = new System.Drawing.Point(6, 355);
            this.btnViewCharacteristics.Name = "btnViewCharacteristics";
            this.btnViewCharacteristics.Size = new System.Drawing.Size(164, 47);
            this.btnViewCharacteristics.TabIndex = 5;
            this.btnViewCharacteristics.Text = "Показать характеристики";
            this.btnViewCharacteristics.UseVisualStyleBackColor = false;
            this.btnViewCharacteristics.Click += new System.EventHandler(this.btn_table_view_2_Click);
            // 
            // cbSubstancesNameDesc
            // 
            this.cbSubstancesNameDesc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbSubstancesNameDesc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubstancesNameDesc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbSubstancesNameDesc.FormattingEnabled = true;
            this.cbSubstancesNameDesc.Location = new System.Drawing.Point(231, 366);
            this.cbSubstancesNameDesc.Name = "cbSubstancesNameDesc";
            this.cbSubstancesNameDesc.Size = new System.Drawing.Size(360, 24);
            this.cbSubstancesNameDesc.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvExperimentsView);
            this.tabPage2.Controls.Add(this.cbSubstancesNameExp);
            this.tabPage2.Controls.Add(this.btnTableView);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 408);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Экспериментальные точки";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvExperimentsView
            // 
            this.dgvExperimentsView.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvExperimentsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExperimentsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Exp_Id,
            this.Solubility,
            this.Temperature,
            this.Pressure});
            this.dgvExperimentsView.Location = new System.Drawing.Point(5, 6);
            this.dgvExperimentsView.Name = "dgvExperimentsView";
            this.dgvExperimentsView.RowHeadersWidth = 51;
            this.dgvExperimentsView.RowTemplate.Height = 24;
            this.dgvExperimentsView.Size = new System.Drawing.Size(756, 342);
            this.dgvExperimentsView.TabIndex = 0;
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
            // cbSubstancesNameExp
            // 
            this.cbSubstancesNameExp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbSubstancesNameExp.DisplayMember = "Name";
            this.cbSubstancesNameExp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubstancesNameExp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbSubstancesNameExp.FormattingEnabled = true;
            this.cbSubstancesNameExp.Location = new System.Drawing.Point(231, 366);
            this.cbSubstancesNameExp.Name = "cbSubstancesNameExp";
            this.cbSubstancesNameExp.Size = new System.Drawing.Size(360, 24);
            this.cbSubstancesNameExp.TabIndex = 3;
            this.cbSubstancesNameExp.ValueMember = "Id";
            // 
            // Enter_Data
            // 
            this.Enter_Data.Controls.Add(this.dgvEnterData);
            this.Enter_Data.Controls.Add(this.cbSubstancesNameEntrerData);
            this.Enter_Data.Controls.Add(this.btnEnterData);
            this.Enter_Data.Location = new System.Drawing.Point(4, 25);
            this.Enter_Data.Name = "Enter_Data";
            this.Enter_Data.Padding = new System.Windows.Forms.Padding(3);
            this.Enter_Data.Size = new System.Drawing.Size(768, 408);
            this.Enter_Data.TabIndex = 2;
            this.Enter_Data.Text = "Ввод экспериментальных данных";
            this.Enter_Data.UseVisualStyleBackColor = true;
            // 
            // substancesTableAdapter
            // 
            this.substancesTableAdapter.ClearBeforeFill = true;
            // 
            // dgvEnterData
            // 
            this.dgvEnterData.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvEnterData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnterData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvEnterData.Location = new System.Drawing.Point(6, 6);
            this.dgvEnterData.Name = "dgvEnterData";
            this.dgvEnterData.RowHeadersWidth = 51;
            this.dgvEnterData.RowTemplate.Height = 24;
            this.dgvEnterData.Size = new System.Drawing.Size(756, 342);
            this.dgvEnterData.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Exp id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Solubility";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Temperature";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Pressure";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // cbSubstancesNameEntrerData
            // 
            this.cbSubstancesNameEntrerData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbSubstancesNameEntrerData.DisplayMember = "Name";
            this.cbSubstancesNameEntrerData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubstancesNameEntrerData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbSubstancesNameEntrerData.FormattingEnabled = true;
            this.cbSubstancesNameEntrerData.Location = new System.Drawing.Point(232, 366);
            this.cbSubstancesNameEntrerData.Name = "cbSubstancesNameEntrerData";
            this.cbSubstancesNameEntrerData.Size = new System.Drawing.Size(360, 24);
            this.cbSubstancesNameEntrerData.TabIndex = 6;
            this.cbSubstancesNameEntrerData.ValueMember = "Id";
            // 
            // btnEnterData
            // 
            this.btnEnterData.BackColor = System.Drawing.Color.AliceBlue;
            this.btnEnterData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnterData.Location = new System.Drawing.Point(7, 355);
            this.btnEnterData.Name = "btnEnterData";
            this.btnEnterData.Size = new System.Drawing.Size(164, 47);
            this.btnEnterData.TabIndex = 5;
            this.btnEnterData.Text = "Показать значения растворимости";
            this.btnEnterData.UseVisualStyleBackColor = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescriptorsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.substancesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Descriptors_1DataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExperimentsView)).EndInit();
            this.Enter_Data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnterData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDescriptorsView;
        private Button btnTableView;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Name_of_descriptor;
        private DataGridViewTextBoxColumn Value;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvExperimentsView;
        private DataGridViewTextBoxColumn Exp_Id;
        private DB_Descriptors_1DataSet dB_Descriptors_1DataSet;
        private BindingSource substancesBindingSource;
        private DB_Descriptors_1DataSetTableAdapters.SubstancesTableAdapter substancesTableAdapter;
        private DataGridViewTextBoxColumn Solubility;
        private DataGridViewTextBoxColumn Temperature;
        private DataGridViewTextBoxColumn Pressure;
        private Button btnViewCharacteristics;
        private ComboBox cbSubstancesNameDesc;
        private ComboBox cbSubstancesNameExp;
        private TabPage Enter_Data;
        private DataGridView dgvEnterData;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private ComboBox cbSubstancesNameEntrerData;
        private Button btnEnterData;
    }
}