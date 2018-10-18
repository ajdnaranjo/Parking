namespace Parking.MasterForms
{
    partial class FrmEditClient
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
            this.TxtCelPhone = new System.Windows.Forms.TextBox();
            this.TxtFullName = new System.Windows.Forms.TextBox();
            this.CbDocType = new System.Windows.Forms.ComboBox();
            this.TxtDocument = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GvData = new System.Windows.Forms.DataGridView();
            this.Plate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Document = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CelPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPlate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GvData)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtCelPhone
            // 
            this.TxtCelPhone.Location = new System.Drawing.Point(126, 87);
            this.TxtCelPhone.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCelPhone.Name = "TxtCelPhone";
            this.TxtCelPhone.Size = new System.Drawing.Size(148, 20);
            this.TxtCelPhone.TabIndex = 16;
            // 
            // TxtFullName
            // 
            this.TxtFullName.Location = new System.Drawing.Point(126, 55);
            this.TxtFullName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFullName.Name = "TxtFullName";
            this.TxtFullName.Size = new System.Drawing.Size(437, 20);
            this.TxtFullName.TabIndex = 15;
            this.TxtFullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFullName_KeyPress);
            // 
            // CbDocType
            // 
            this.CbDocType.FormattingEnabled = true;
            this.CbDocType.Location = new System.Drawing.Point(415, 22);
            this.CbDocType.Margin = new System.Windows.Forms.Padding(4);
            this.CbDocType.Name = "CbDocType";
            this.CbDocType.Size = new System.Drawing.Size(148, 21);
            this.CbDocType.TabIndex = 14;
            this.CbDocType.Visible = false;
            // 
            // TxtDocument
            // 
            this.TxtDocument.Location = new System.Drawing.Point(126, 23);
            this.TxtDocument.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDocument.Name = "TxtDocument";
            this.TxtDocument.Size = new System.Drawing.Size(148, 20);
            this.TxtDocument.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(285, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tipo documento:";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Celular:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Documento:";
            // 
            // GvData
            // 
            this.GvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Plate,
            this.Document,
            this.DocType,
            this.FullName,
            this.CelPhone});
            this.GvData.Location = new System.Drawing.Point(27, 164);
            this.GvData.Name = "GvData";
            this.GvData.Size = new System.Drawing.Size(536, 263);
            this.GvData.TabIndex = 17;
            this.GvData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GvData_CellDoubleClick);
            // 
            // Plate
            // 
            this.Plate.DataPropertyName = "Plate";
            this.Plate.HeaderText = "Placa";
            this.Plate.Name = "Plate";
            this.Plate.Width = 80;
            // 
            // Document
            // 
            this.Document.DataPropertyName = "Document";
            this.Document.HeaderText = "Documento";
            this.Document.Name = "Document";
            // 
            // DocType
            // 
            this.DocType.DataPropertyName = "DocTypeID";
            this.DocType.HeaderText = "Tipo doc.";
            this.DocType.Name = "DocType";
            this.DocType.Visible = false;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "Name";
            this.FullName.HeaderText = "Nombre";
            this.FullName.Name = "FullName";
            this.FullName.Width = 200;
            // 
            // CelPhone
            // 
            this.CelPhone.DataPropertyName = "CelPhone";
            this.CelPhone.HeaderText = "Celular";
            this.CelPhone.Name = "CelPhone";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(488, 85);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 18;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(27, 138);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(454, 20);
            this.TxtSearch.TabIndex = 19;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(488, 135);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 20;
            this.BtnSearch.Text = "Buscar";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Placa:";
            // 
            // TxtPlate
            // 
            this.TxtPlate.Location = new System.Drawing.Point(346, 87);
            this.TxtPlate.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPlate.Name = "TxtPlate";
            this.TxtPlate.Size = new System.Drawing.Size(135, 20);
            this.TxtPlate.TabIndex = 22;
            this.TxtPlate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPlate_KeyPress);
            // 
            // FrmEditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 450);
            this.Controls.Add(this.TxtPlate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.GvData);
            this.Controls.Add(this.TxtCelPhone);
            this.Controls.Add(this.TxtFullName);
            this.Controls.Add(this.CbDocType);
            this.Controls.Add(this.TxtDocument);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FrmEditClient";
            this.Text = "Editar Cliente";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.GvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCelPhone;
        private System.Windows.Forms.TextBox TxtFullName;
        private System.Windows.Forms.ComboBox CbDocType;
        private System.Windows.Forms.TextBox TxtDocument;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GvData;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPlate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Document;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocType;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CelPhone;
    }
}