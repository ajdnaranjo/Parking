namespace Parking.Reports
{
    partial class FrmMonthlyPayments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvReport = new System.Windows.Forms.DataGridView();
            this.ReceiptID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Document = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentDescriptiion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BtnExport = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvReport
            // 
            this.DgvReport.AllowUserToAddRows = false;
            this.DgvReport.AllowUserToDeleteRows = false;
            this.DgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReceiptID,
            this.Document,
            this.ClientName,
            this.CellPhone,
            this.Plate,
            this.PaymentDate,
            this.ExpirationDate,
            this.PaymentDescriptiion,
            this.Status});
            this.DgvReport.Location = new System.Drawing.Point(12, 53);
            this.DgvReport.Name = "DgvReport";
            this.DgvReport.ReadOnly = true;
            this.DgvReport.Size = new System.Drawing.Size(1264, 486);
            this.DgvReport.TabIndex = 0;
            // 
            // ReceiptID
            // 
            this.ReceiptID.DataPropertyName = "ReceiptID";
            this.ReceiptID.HeaderText = "No. Recibo";
            this.ReceiptID.Name = "ReceiptID";
            this.ReceiptID.ReadOnly = true;
            this.ReceiptID.Width = 90;
            // 
            // Document
            // 
            this.Document.DataPropertyName = "Document";
            this.Document.HeaderText = "Documento";
            this.Document.Name = "Document";
            this.Document.ReadOnly = true;
            this.Document.Width = 90;
            // 
            // ClientName
            // 
            this.ClientName.DataPropertyName = "Name";
            this.ClientName.HeaderText = "Nombres";
            this.ClientName.Name = "ClientName";
            this.ClientName.ReadOnly = true;
            this.ClientName.Width = 230;
            // 
            // CellPhone
            // 
            this.CellPhone.DataPropertyName = "CellPhone";
            this.CellPhone.HeaderText = "Celular";
            this.CellPhone.Name = "CellPhone";
            this.CellPhone.ReadOnly = true;
            this.CellPhone.Width = 90;
            // 
            // Plate
            // 
            this.Plate.DataPropertyName = "Plate";
            this.Plate.HeaderText = "Placa";
            this.Plate.Name = "Plate";
            this.Plate.ReadOnly = true;
            this.Plate.Width = 90;
            // 
            // PaymentDate
            // 
            this.PaymentDate.DataPropertyName = "PaymentDate";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            dataGridViewCellStyle1.NullValue = null;
            this.PaymentDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.PaymentDate.HeaderText = "Fecha Ingreso";
            this.PaymentDate.Name = "PaymentDate";
            this.PaymentDate.ReadOnly = true;
            this.PaymentDate.Width = 130;
            // 
            // ExpirationDate
            // 
            this.ExpirationDate.DataPropertyName = "ExpirationDate";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.ExpirationDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.ExpirationDate.HeaderText = "Fecha vencimiento.";
            this.ExpirationDate.Name = "ExpirationDate";
            this.ExpirationDate.ReadOnly = true;
            this.ExpirationDate.Width = 130;
            // 
            // PaymentDescriptiion
            // 
            this.PaymentDescriptiion.DataPropertyName = "PaymentDescriptiion";
            this.PaymentDescriptiion.HeaderText = "Tipo pago";
            this.PaymentDescriptiion.Name = "PaymentDescriptiion";
            this.PaymentDescriptiion.ReadOnly = true;
            this.PaymentDescriptiion.Width = 90;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Activo";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Status.Width = 80;
            // 
            // BtnExport
            // 
            this.BtnExport.Location = new System.Drawing.Point(332, 17);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(75, 23);
            this.BtnExport.TabIndex = 1;
            this.BtnExport.Text = "Exportar";
            this.BtnExport.UseVisualStyleBackColor = true;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(12, 19);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(233, 20);
            this.TxtSearch.TabIndex = 3;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(251, 17);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 4;
            this.BtnSearch.Text = "Buscar";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // FrmMonthlyPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 587);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.BtnExport);
            this.Controls.Add(this.DgvReport);
            this.Name = "FrmMonthlyPayments";
            this.Text = "Mensualidades Activas";
            ((System.ComponentModel.ISupportInitialize)(this.DgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvReport;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Names;
        private System.Windows.Forms.Button BtnExport;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiptID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Document;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpirationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentDescriptiion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
    }
}