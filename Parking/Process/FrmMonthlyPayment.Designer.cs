namespace Parking.Process
{
    partial class FrmMonthlyPayment
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDocument = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CbDocType = new System.Windows.Forms.ComboBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtCelPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPlate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtPayment = new System.Windows.Forms.TextBox();
            this.TxtTotalPayment = new System.Windows.Forms.TextBox();
            this.TxtRefund = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Documento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Celular:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre:";
            // 
            // TxtDocument
            // 
            this.TxtDocument.Location = new System.Drawing.Point(136, 51);
            this.TxtDocument.Margin = new System.Windows.Forms.Padding(4);
            this.TxtDocument.Name = "TxtDocument";
            this.TxtDocument.Size = new System.Drawing.Size(148, 23);
            this.TxtDocument.TabIndex = 5;
            this.TxtDocument.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDocument_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(295, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo documento:";
            this.label5.Visible = false;
            // 
            // CbDocType
            // 
            this.CbDocType.FormattingEnabled = true;
            this.CbDocType.Location = new System.Drawing.Point(425, 51);
            this.CbDocType.Margin = new System.Windows.Forms.Padding(4);
            this.CbDocType.Name = "CbDocType";
            this.CbDocType.Size = new System.Drawing.Size(148, 24);
            this.CbDocType.TabIndex = 6;
            this.CbDocType.Visible = false;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(136, 83);
            this.TxtName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(437, 23);
            this.TxtName.TabIndex = 7;
            // 
            // TxtCelPhone
            // 
            this.TxtCelPhone.Location = new System.Drawing.Point(136, 115);
            this.TxtCelPhone.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCelPhone.Name = "TxtCelPhone";
            this.TxtCelPhone.Size = new System.Drawing.Size(148, 23);
            this.TxtCelPhone.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Placa:";
            // 
            // TxtPlate
            // 
            this.TxtPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPlate.Location = new System.Drawing.Point(136, 146);
            this.TxtPlate.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPlate.Name = "TxtPlate";
            this.TxtPlate.Size = new System.Drawing.Size(148, 30);
            this.TxtPlate.TabIndex = 10;
            this.TxtPlate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPlate_KeyPress);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(419, 199);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 31);
            this.label6.TabIndex = 11;
            this.label6.Text = "Devuelta";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(223, 199);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 31);
            this.label7.TabIndex = 12;
            this.label7.Text = "Pago";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 199);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 31);
            this.label8.TabIndex = 13;
            this.label8.Text = "Valor a pagar";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtPayment
            // 
            this.TxtPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPayment.Location = new System.Drawing.Point(223, 243);
            this.TxtPayment.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPayment.Name = "TxtPayment";
            this.TxtPayment.Size = new System.Drawing.Size(188, 38);
            this.TxtPayment.TabIndex = 14;
            this.TxtPayment.TextChanged += new System.EventHandler(this.TxtPayment_TextChanged);
            this.TxtPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPayment_KeyPress);
            // 
            // TxtTotalPayment
            // 
            this.TxtTotalPayment.Enabled = false;
            this.TxtTotalPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalPayment.Location = new System.Drawing.Point(27, 243);
            this.TxtTotalPayment.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTotalPayment.Name = "TxtTotalPayment";
            this.TxtTotalPayment.Size = new System.Drawing.Size(188, 38);
            this.TxtTotalPayment.TabIndex = 15;
            // 
            // TxtRefund
            // 
            this.TxtRefund.Enabled = false;
            this.TxtRefund.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRefund.Location = new System.Drawing.Point(419, 243);
            this.TxtRefund.Margin = new System.Windows.Forms.Padding(4);
            this.TxtRefund.Name = "TxtRefund";
            this.TxtRefund.Size = new System.Drawing.Size(188, 38);
            this.TxtRefund.TabIndex = 16;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(504, 303);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(103, 41);
            this.BtnSave.TabIndex = 17;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // FrmMonthlyPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 356);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtRefund);
            this.Controls.Add(this.TxtTotalPayment);
            this.Controls.Add(this.TxtPayment);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtPlate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCelPhone);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.CbDocType);
            this.Controls.Add(this.TxtDocument);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMonthlyPayment";
            this.Text = "FrmMonthlyPayment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDocument;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbDocType;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtCelPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPlate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtPayment;
        private System.Windows.Forms.TextBox TxtTotalPayment;
        private System.Windows.Forms.TextBox TxtRefund;
        private System.Windows.Forms.Button BtnSave;
    }
}