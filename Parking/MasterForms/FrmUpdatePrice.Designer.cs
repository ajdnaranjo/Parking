
namespace Parking.MasterForms
{
    partial class FrmUpdatePrice
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
            this.label4 = new System.Windows.Forms.Label();
            this.cbPaymentMethods = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblPaymentID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Metodo de pago :";
            // 
            // cbPaymentMethods
            // 
            this.cbPaymentMethods.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaymentMethods.FormattingEnabled = true;
            this.cbPaymentMethods.Location = new System.Drawing.Point(205, 51);
            this.cbPaymentMethods.Name = "cbPaymentMethods";
            this.cbPaymentMethods.Size = new System.Drawing.Size(283, 28);
            this.cbPaymentMethods.TabIndex = 6;
            this.cbPaymentMethods.SelectedValueChanged += new System.EventHandler(this.cbPaymentMethods_SelectedValueChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(374, 98);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 29);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtValue
            // 
            this.txtValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.Location = new System.Drawing.Point(205, 101);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(163, 26);
            this.txtValue.TabIndex = 8;
            this.txtValue.TextChanged += new System.EventHandler(this.txtValue_TextChanged);
            this.txtValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Valor:";
            // 
            // LblPaymentID
            // 
            this.LblPaymentID.AutoSize = true;
            this.LblPaymentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPaymentID.Location = new System.Drawing.Point(40, 132);
            this.LblPaymentID.Name = "LblPaymentID";
            this.LblPaymentID.Size = new System.Drawing.Size(0, 24);
            this.LblPaymentID.TabIndex = 10;
            this.LblPaymentID.Visible = false;
            // 
            // FrmUpdatePrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 165);
            this.Controls.Add(this.LblPaymentID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cbPaymentMethods);
            this.Controls.Add(this.label4);
            this.Name = "FrmUpdatePrice";
            this.Text = "Actualizar precio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbPaymentMethods;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblPaymentID;
    }
}