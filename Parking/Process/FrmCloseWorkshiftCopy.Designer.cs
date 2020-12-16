namespace Parking.Process
{
    partial class FrmCloseWorkshiftCopy
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CloseWorkShitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Print = new System.Windows.Forms.DataGridViewLinkColumn();
            this.AppUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToDeleteRows = false;
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.CloseWorkShitDate,
            this.Print,
            this.AppUserID});
            this.DgvData.Location = new System.Drawing.Point(24, 34);
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.Size = new System.Drawing.Size(478, 247);
            this.DgvData.TabIndex = 0;
            this.DgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvData_CellContentClick);
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "Name";
            this.UserName.HeaderText = "Usuario";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // CloseWorkShitDate
            // 
            this.CloseWorkShitDate.DataPropertyName = "WorkShiftCloseDate";
            this.CloseWorkShitDate.HeaderText = "Fecha cierre";
            this.CloseWorkShitDate.Name = "CloseWorkShitDate";
            this.CloseWorkShitDate.ReadOnly = true;
            this.CloseWorkShitDate.Width = 150;
            // 
            // Print
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Print.DefaultCellStyle = dataGridViewCellStyle1;
            this.Print.HeaderText = "";
            this.Print.Name = "Print";
            this.Print.ReadOnly = true;
            this.Print.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Print.Text = "Imprimir";
            this.Print.UseColumnTextForLinkValue = true;
            // 
            // AppUserID
            // 
            this.AppUserID.DataPropertyName = "UserID";
            this.AppUserID.HeaderText = "AppUserID";
            this.AppUserID.Name = "AppUserID";
            this.AppUserID.ReadOnly = true;
            this.AppUserID.Visible = false;
            // 
            // FrmCloseWorkshiftCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 302);
            this.Controls.Add(this.DgvData);
            this.Name = "FrmCloseWorkshiftCopy";
            this.Text = "Copia cierro de turno";
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CloseWorkShitDate;
        private System.Windows.Forms.DataGridViewLinkColumn Print;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppUserID;
    }
}