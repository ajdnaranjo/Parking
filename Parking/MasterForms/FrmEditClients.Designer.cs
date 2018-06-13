namespace Parking.MasterForms
{
    partial class FrmEditClients
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
            this.TxtName = new System.Windows.Forms.TextBox();
            this.CbDocType = new System.Windows.Forms.ComboBox();
            this.TxtDocument = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(126, 55);
            this.TxtName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(437, 20);
            this.TxtName.TabIndex = 15;
            // 
            // CbDocType
            // 
            this.CbDocType.FormattingEnabled = true;
            this.CbDocType.Location = new System.Drawing.Point(415, 23);
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
            this.label5.Location = new System.Drawing.Point(285, 26);
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
            // FrmEditClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtCelPhone);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.CbDocType);
            this.Controls.Add(this.TxtDocument);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FrmEditClients";
            this.Text = "FrmEditClients";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCelPhone;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.ComboBox CbDocType;
        private System.Windows.Forms.TextBox TxtDocument;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}