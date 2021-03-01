
namespace Parking.Process
{
    partial class FrmUpdatePlate
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtActualPlate = new System.Windows.Forms.TextBox();
            this.txtNewPlate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(283, 77);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 23);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Placa actual:";
            // 
            // txtActualPlate
            // 
            this.txtActualPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActualPlate.Location = new System.Drawing.Point(161, 77);
            this.txtActualPlate.Name = "txtActualPlate";
            this.txtActualPlate.Size = new System.Drawing.Size(100, 22);
            this.txtActualPlate.TabIndex = 2;
            this.txtActualPlate.TextChanged += new System.EventHandler(this.txtActualPlate_TextChanged);
            this.txtActualPlate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtActualPlate_KeyPress);
            // 
            // txtNewPlate
            // 
            this.txtNewPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPlate.Location = new System.Drawing.Point(161, 116);
            this.txtNewPlate.Name = "txtNewPlate";
            this.txtNewPlate.Size = new System.Drawing.Size(100, 22);
            this.txtNewPlate.TabIndex = 4;
            this.txtNewPlate.TextChanged += new System.EventHandler(this.txtNewPlate_TextChanged);
            this.txtNewPlate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewPlate_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Placa nueva:";
           
            // 
            // FrmUpdatePlate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 196);
            this.Controls.Add(this.txtNewPlate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtActualPlate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Name = "FrmUpdatePlate";
            this.Text = "Actualizar Placa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtActualPlate;
        private System.Windows.Forms.TextBox txtNewPlate;
        private System.Windows.Forms.Label label2;
    }
}