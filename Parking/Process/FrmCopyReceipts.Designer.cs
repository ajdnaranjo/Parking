namespace Parking.Process
{
    partial class FrmCopyReceipts
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
            this.TxtReceipt = new System.Windows.Forms.TextBox();
            this.CbExit = new System.Windows.Forms.CheckBox();
            this.CbEntry = new System.Windows.Forms.CheckBox();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número factura:";
            // 
            // TxtReceipt
            // 
            this.TxtReceipt.Location = new System.Drawing.Point(110, 52);
            this.TxtReceipt.Name = "TxtReceipt";
            this.TxtReceipt.Size = new System.Drawing.Size(166, 20);
            this.TxtReceipt.TabIndex = 1;
            this.TxtReceipt.Leave += new System.EventHandler(this.TxtReceipt_Leave);
            // 
            // CbExit
            // 
            this.CbExit.AutoSize = true;
            this.CbExit.Enabled = false;
            this.CbExit.Location = new System.Drawing.Point(177, 78);
            this.CbExit.Name = "CbExit";
            this.CbExit.Size = new System.Drawing.Size(55, 17);
            this.CbExit.TabIndex = 2;
            this.CbExit.Text = "Salida";
            this.CbExit.UseVisualStyleBackColor = true;
            // 
            // CbEntry
            // 
            this.CbEntry.AutoSize = true;
            this.CbEntry.Enabled = false;
            this.CbEntry.Location = new System.Drawing.Point(110, 78);
            this.CbEntry.Name = "CbEntry";
            this.CbEntry.Size = new System.Drawing.Size(61, 17);
            this.CbEntry.TabIndex = 3;
            this.CbEntry.Text = "Ingreso";
            this.CbEntry.UseVisualStyleBackColor = true;
            // 
            // BtnPrint
            // 
            this.BtnPrint.Location = new System.Drawing.Point(282, 50);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(75, 23);
            this.BtnPrint.TabIndex = 4;
            this.BtnPrint.Text = "Imprimir";
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // FrmCopyReceipts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 156);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.CbEntry);
            this.Controls.Add(this.CbExit);
            this.Controls.Add(this.TxtReceipt);
            this.Controls.Add(this.label1);
            this.Name = "FrmCopyReceipts";
            this.Text = "Copia de recibos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtReceipt;
        private System.Windows.Forms.CheckBox CbExit;
        private System.Windows.Forms.CheckBox CbEntry;
        private System.Windows.Forms.Button BtnPrint;
    }
}