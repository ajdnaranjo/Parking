namespace Parking.Process
{
    partial class FrmRegistry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.tHour = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.lblSalida = new System.Windows.Forms.Label();
            this.txtTotalPayment = new System.Windows.Forms.TextBox();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRefund = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtLocker = new System.Windows.Forms.TextBox();
            this.DgvLastMovements = new System.Windows.Forms.DataGridView();
            this.RegistryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Locker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Refund = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CbDayPayment = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLastMovements)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa:";
            // 
            // txtPlate
            // 
            this.txtPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 120F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlate.Location = new System.Drawing.Point(168, 105);
            this.txtPlate.MaxLength = 6;
            this.txtPlate.Name = "txtPlate";
            this.txtPlate.Size = new System.Drawing.Size(645, 189);
            this.txtPlate.TabIndex = 1;
            this.txtPlate.TextChanged += new System.EventHandler(this.txtPlate_TextChanged);
            this.txtPlate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlate_KeyPress);
            this.txtPlate.Leave += new System.EventHandler(this.txtPlate_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hora:";
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHour.Location = new System.Drawing.Point(161, 29);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(133, 39);
            this.lblHour.TabIndex = 2;
            this.lblHour.Text = "lblHour";
            // 
            // tHour
            // 
            this.tHour.Enabled = true;
            this.tHour.Tick += new System.EventHandler(this.tHour_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(163, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingreso:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(163, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Salida:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total a pagar:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreso.Location = new System.Drawing.Point(263, 315);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(0, 26);
            this.lblIngreso.TabIndex = 6;
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalida.Location = new System.Drawing.Point(263, 355);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(0, 26);
            this.lblSalida.TabIndex = 7;
            // 
            // txtTotalPayment
            // 
            this.txtTotalPayment.Enabled = false;
            this.txtTotalPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPayment.Location = new System.Drawing.Point(57, 443);
            this.txtTotalPayment.Name = "txtTotalPayment";
            this.txtTotalPayment.Size = new System.Drawing.Size(240, 68);
            this.txtTotalPayment.TabIndex = 0;
            // 
            // txtPayment
            // 
            this.txtPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayment.Location = new System.Drawing.Point(316, 443);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(240, 68);
            this.txtPayment.TabIndex = 4;
            this.txtPayment.Text = "0";
            this.txtPayment.TextChanged += new System.EventHandler(this.txtPayment_TextChanged);
            this.txtPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPayment_KeyPress);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(316, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 31);
            this.label6.TabIndex = 9;
            this.label6.Text = "Pago:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRefund
            // 
            this.txtRefund.Enabled = false;
            this.txtRefund.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefund.Location = new System.Drawing.Point(573, 443);
            this.txtRefund.Name = "txtRefund";
            this.txtRefund.Size = new System.Drawing.Size(240, 68);
            this.txtRefund.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(573, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 31);
            this.label7.TabIndex = 11;
            this.label7.Text = "Devuelta:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(39, 529);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(797, 38);
            this.lblMessage.TabIndex = 12;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(642, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 26);
            this.label8.TabIndex = 13;
            this.label8.Text = "Locker:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtLocker
            // 
            this.TxtLocker.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLocker.Location = new System.Drawing.Point(738, 352);
            this.TxtLocker.MaxLength = 2;
            this.TxtLocker.Name = "TxtLocker";
            this.TxtLocker.Size = new System.Drawing.Size(75, 32);
            this.TxtLocker.TabIndex = 3;
            this.TxtLocker.Tag = "";
            this.TxtLocker.Text = "0";
            this.TxtLocker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLocker_KeyPress);
            // 
            // DgvLastMovements
            // 
            this.DgvLastMovements.AllowUserToAddRows = false;
            this.DgvLastMovements.AllowUserToDeleteRows = false;
            this.DgvLastMovements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLastMovements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegistryID,
            this.Plate,
            this.EntryDate,
            this.ExitDate,
            this.Locker,
            this.TotalPayment,
            this.Payment,
            this.Refund});
            this.DgvLastMovements.Location = new System.Drawing.Point(57, 529);
            this.DgvLastMovements.Name = "DgvLastMovements";
            this.DgvLastMovements.ReadOnly = true;
            this.DgvLastMovements.Size = new System.Drawing.Size(756, 209);
            this.DgvLastMovements.TabIndex = 15;
            // 
            // RegistryID
            // 
            this.RegistryID.DataPropertyName = "RegistryID";
            this.RegistryID.HeaderText = "No Factura";
            this.RegistryID.Name = "RegistryID";
            this.RegistryID.ReadOnly = true;
            this.RegistryID.Width = 90;
            // 
            // Plate
            // 
            this.Plate.DataPropertyName = "Plate";
            this.Plate.HeaderText = "Placa";
            this.Plate.Name = "Plate";
            this.Plate.ReadOnly = true;
            this.Plate.Width = 70;
            // 
            // EntryDate
            // 
            this.EntryDate.DataPropertyName = "EntryDate";
            dataGridViewCellStyle13.Format = "g";
            dataGridViewCellStyle13.NullValue = null;
            this.EntryDate.DefaultCellStyle = dataGridViewCellStyle13;
            this.EntryDate.HeaderText = "Fecha Entrada";
            this.EntryDate.Name = "EntryDate";
            this.EntryDate.ReadOnly = true;
            this.EntryDate.Width = 110;
            // 
            // ExitDate
            // 
            this.ExitDate.DataPropertyName = "ExitDate";
            dataGridViewCellStyle14.Format = "g";
            dataGridViewCellStyle14.NullValue = null;
            this.ExitDate.DefaultCellStyle = dataGridViewCellStyle14;
            this.ExitDate.HeaderText = "Fecha  Salida";
            this.ExitDate.Name = "ExitDate";
            this.ExitDate.ReadOnly = true;
            this.ExitDate.Width = 110;
            // 
            // Locker
            // 
            this.Locker.DataPropertyName = "Locker";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Locker.DefaultCellStyle = dataGridViewCellStyle15;
            this.Locker.HeaderText = "Locker";
            this.Locker.Name = "Locker";
            this.Locker.ReadOnly = true;
            this.Locker.Width = 50;
            // 
            // TotalPayment
            // 
            this.TotalPayment.DataPropertyName = "TotalPayment";
            dataGridViewCellStyle16.Format = "C0";
            this.TotalPayment.DefaultCellStyle = dataGridViewCellStyle16;
            this.TotalPayment.HeaderText = "Total a Pagar";
            this.TotalPayment.Name = "TotalPayment";
            this.TotalPayment.ReadOnly = true;
            // 
            // Payment
            // 
            this.Payment.DataPropertyName = "Payment";
            dataGridViewCellStyle17.Format = "C0";
            this.Payment.DefaultCellStyle = dataGridViewCellStyle17;
            this.Payment.HeaderText = "Pagó";
            this.Payment.Name = "Payment";
            this.Payment.ReadOnly = true;
            this.Payment.Width = 90;
            // 
            // Refund
            // 
            this.Refund.DataPropertyName = "Refund";
            dataGridViewCellStyle18.Format = "C0";
            this.Refund.DefaultCellStyle = dataGridViewCellStyle18;
            this.Refund.HeaderText = "Devuelta";
            this.Refund.Name = "Refund";
            this.Refund.ReadOnly = true;
            this.Refund.Width = 90;
            // 
            // CbDayPayment
            // 
            this.CbDayPayment.AutoSize = true;
            this.CbDayPayment.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CbDayPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbDayPayment.Location = new System.Drawing.Point(688, 313);
            this.CbDayPayment.Name = "CbDayPayment";
            this.CbDayPayment.Size = new System.Drawing.Size(125, 30);
            this.CbDayPayment.TabIndex = 2;
            this.CbDayPayment.Text = "Pago día";
            this.CbDayPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CbDayPayment.UseVisualStyleBackColor = true;
            this.CbDayPayment.CheckedChanged += new System.EventHandler(this.CbDayPayment_CheckedChanged);
            // 
            // FrmRegistry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 750);
            this.Controls.Add(this.CbDayPayment);
            this.Controls.Add(this.DgvLastMovements);
            this.Controls.Add(this.TxtLocker);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtRefund);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotalPayment);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.lblIngreso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.txtPlate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmRegistry";
            this.Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)(this.DgvLastMovements)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Timer tHour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.TextBox txtTotalPayment;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRefund;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtLocker;
        private System.Windows.Forms.DataGridView DgvLastMovements;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExitDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Locker;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Refund;
        private System.Windows.Forms.CheckBox CbDayPayment;
    }
}