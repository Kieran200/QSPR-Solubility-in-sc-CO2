namespace Interface_for_BD
{
    partial class frmCluster
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
            this.btnClusterExcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClusterExcel
            // 
            this.btnClusterExcel.BackColor = System.Drawing.Color.AliceBlue;
            this.btnClusterExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClusterExcel.Location = new System.Drawing.Point(83, 71);
            this.btnClusterExcel.Name = "btnClusterExcel";
            this.btnClusterExcel.Size = new System.Drawing.Size(128, 66);
            this.btnClusterExcel.TabIndex = 0;
            this.btnClusterExcel.Text = "Список веществ и дескрипторов в EXCEl";
            this.btnClusterExcel.UseVisualStyleBackColor = false;
            this.btnClusterExcel.Click += new System.EventHandler(this.btnClusterExcel_Click);
            // 
            // frmCluster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(295, 229);
            this.Controls.Add(this.btnClusterExcel);
            this.Name = "frmCluster";
            this.Text = "frmCluster";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClusterExcel;
    }
}