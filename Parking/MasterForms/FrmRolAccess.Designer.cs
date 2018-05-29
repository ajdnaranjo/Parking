namespace Parking.MasterForms
{
    partial class FrmRolAccess
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtUserId = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtPwd = new System.Windows.Forms.TextBox();
            this.CbStatus = new System.Windows.Forms.CheckBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.CbRol = new System.Windows.Forms.ComboBox();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.CbRolName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FormId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rol:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre:";
            // 
            // TxtUserId
            // 
            this.TxtUserId.Location = new System.Drawing.Point(117, 40);
            this.TxtUserId.Name = "TxtUserId";
            this.TxtUserId.Size = new System.Drawing.Size(100, 20);
            this.TxtUserId.TabIndex = 5;
            this.TxtUserId.Leave += new System.EventHandler(this.TxtUserId_Leave);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(281, 40);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(307, 20);
            this.TxtName.TabIndex = 6;
            // 
            // TxtPwd
            // 
            this.TxtPwd.Location = new System.Drawing.Point(117, 75);
            this.TxtPwd.Name = "TxtPwd";
            this.TxtPwd.PasswordChar = '*';
            this.TxtPwd.Size = new System.Drawing.Size(100, 20);
            this.TxtPwd.TabIndex = 7;
            // 
            // CbStatus
            // 
            this.CbStatus.AutoSize = true;
            this.CbStatus.Checked = true;
            this.CbStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbStatus.Location = new System.Drawing.Point(119, 110);
            this.CbStatus.Name = "CbStatus";
            this.CbStatus.Size = new System.Drawing.Size(15, 14);
            this.CbStatus.TabIndex = 8;
            this.CbStatus.UseVisualStyleBackColor = true;
            this.CbStatus.CheckedChanged += new System.EventHandler(this.CbStatus_CheckedChanged);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(513, 124);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 9;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // CbRol
            // 
            this.CbRol.DisplayMember = "RolName";
            this.CbRol.FormattingEnabled = true;
            this.CbRol.Location = new System.Drawing.Point(281, 74);
            this.CbRol.Name = "CbRol";
            this.CbRol.Size = new System.Drawing.Size(205, 21);
            this.CbRol.TabIndex = 10;
            this.CbRol.ValueMember = "RolId";
            // 
            // DgvData
            // 
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FormId,
            this.Description,
            this.Status});
            this.DgvData.Location = new System.Drawing.Point(52, 204);
            this.DgvData.Name = "DgvData";
            this.DgvData.Size = new System.Drawing.Size(536, 303);
            this.DgvData.TabIndex = 11;
            // 
            // CbRolName
            // 
            this.CbRolName.DisplayMember = "RolName";
            this.CbRolName.FormattingEnabled = true;
            this.CbRolName.Location = new System.Drawing.Point(105, 164);
            this.CbRolName.Name = "CbRolName";
            this.CbRolName.Size = new System.Drawing.Size(205, 21);
            this.CbRolName.TabIndex = 13;
            this.CbRolName.ValueMember = "RolId";
            this.CbRolName.SelectedValueChanged += new System.EventHandler(this.CbRolName_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Rol:";
            // 
            // FormId
            // 
            this.FormId.DataPropertyName = "FormID";
            this.FormId.HeaderText = "FormId";
            this.FormId.Name = "FormId";
            this.FormId.Visible = false;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Formulario";
            this.Description.Name = "Description";
            this.Description.Width = 200;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Estado";
            this.Status.Name = "Status";
            this.Status.Width = 80;
            // 
            // FrmRolAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 538);
            this.Controls.Add(this.CbRolName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DgvData);
            this.Controls.Add(this.CbRol);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.CbStatus);
            this.Controls.Add(this.TxtPwd);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtUserId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRolAccess";
            this.Text = "tsmiFrmRolAcces";
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtUserId;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtPwd;
        private System.Windows.Forms.CheckBox CbStatus;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ComboBox CbRol;
        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.ComboBox CbRolName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
    }
}