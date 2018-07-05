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
            this.FormId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CbRolName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSaveRol = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtRolName = new System.Windows.Forms.TextBox();
            this.CbRolStatus = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnEditRol = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rol:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre:";
            // 
            // TxtUserId
            // 
            this.TxtUserId.Location = new System.Drawing.Point(117, 51);
            this.TxtUserId.Name = "TxtUserId";
            this.TxtUserId.Size = new System.Drawing.Size(100, 20);
            this.TxtUserId.TabIndex = 5;
            this.TxtUserId.Leave += new System.EventHandler(this.TxtUserId_Leave);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(281, 51);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(316, 20);
            this.TxtName.TabIndex = 6;
            // 
            // TxtPwd
            // 
            this.TxtPwd.Location = new System.Drawing.Point(117, 86);
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
            this.CbStatus.Location = new System.Drawing.Point(119, 121);
            this.CbStatus.Name = "CbStatus";
            this.CbStatus.Size = new System.Drawing.Size(15, 14);
            this.CbStatus.TabIndex = 8;
            this.CbStatus.UseVisualStyleBackColor = true;
            this.CbStatus.CheckedChanged += new System.EventHandler(this.CbStatus_CheckedChanged);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(459, 93);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(105, 23);
            this.BtnSave.TabIndex = 9;
            this.BtnSave.Text = "Guardar Usuario";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // CbRol
            // 
            this.CbRol.DisplayMember = "RolName";
            this.CbRol.FormattingEnabled = true;
            this.CbRol.Location = new System.Drawing.Point(281, 85);
            this.CbRol.Name = "CbRol";
            this.CbRol.Size = new System.Drawing.Size(316, 21);
            this.CbRol.TabIndex = 10;
            this.CbRol.ValueMember = "RolId";
            this.CbRol.SelectedValueChanged += new System.EventHandler(this.CbRol_SelectedValueChanged);
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            this.DgvData.AllowUserToDeleteRows = false;
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FormId,
            this.Description,
            this.Status});
            this.DgvData.Location = new System.Drawing.Point(61, 314);
            this.DgvData.Name = "DgvData";
            this.DgvData.Size = new System.Drawing.Size(536, 259);
            this.DgvData.TabIndex = 11;
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
            // CbRolName
            // 
            this.CbRolName.DisplayMember = "RolName";
            this.CbRolName.FormattingEnabled = true;
            this.CbRolName.Location = new System.Drawing.Point(60, 21);
            this.CbRolName.Name = "CbRolName";
            this.CbRolName.Size = new System.Drawing.Size(423, 21);
            this.CbRolName.TabIndex = 13;
            this.CbRolName.ValueMember = "RolId";
            this.CbRolName.SelectedValueChanged += new System.EventHandler(this.CbRolName_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Rol:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CbRolName);
            this.groupBox1.Controls.Add(this.BtnSaveRol);
            this.groupBox1.Location = new System.Drawing.Point(33, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 335);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Roles";
            // 
            // BtnSaveRol
            // 
            this.BtnSaveRol.Location = new System.Drawing.Point(489, 19);
            this.BtnSaveRol.Name = "BtnSaveRol";
            this.BtnSaveRol.Size = new System.Drawing.Size(75, 23);
            this.BtnSaveRol.TabIndex = 15;
            this.BtnSaveRol.Text = "Editar Roles";
            this.BtnSaveRol.UseVisualStyleBackColor = true;
            this.BtnSaveRol.Click += new System.EventHandler(this.BtnSaveRol_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnSave);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(33, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(590, 140);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usuario";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnEditRol);
            this.groupBox3.Controls.Add(this.CbRolStatus);
            this.groupBox3.Controls.Add(this.TxtRolName);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(33, 175);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(590, 81);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nuevo rol";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Rol:";
            // 
            // TxtRolName
            // 
            this.TxtRolName.Location = new System.Drawing.Point(48, 35);
            this.TxtRolName.Name = "TxtRolName";
            this.TxtRolName.Size = new System.Drawing.Size(356, 20);
            this.TxtRolName.TabIndex = 17;
            this.TxtRolName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRolName_KeyPress);
            // 
            // CbRolStatus
            // 
            this.CbRolStatus.AutoSize = true;
            this.CbRolStatus.Checked = true;
            this.CbRolStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbRolStatus.Location = new System.Drawing.Point(469, 38);
            this.CbRolStatus.Name = "CbRolStatus";
            this.CbRolStatus.Size = new System.Drawing.Size(15, 14);
            this.CbRolStatus.TabIndex = 18;
            this.CbRolStatus.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(420, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Estado:";
            // 
            // BtnEditRol
            // 
            this.BtnEditRol.Location = new System.Drawing.Point(489, 33);
            this.BtnEditRol.Name = "BtnEditRol";
            this.BtnEditRol.Size = new System.Drawing.Size(75, 23);
            this.BtnEditRol.TabIndex = 10;
            this.BtnEditRol.Text = "Guardar Rol";
            this.BtnEditRol.UseVisualStyleBackColor = true;
            this.BtnEditRol.Click += new System.EventHandler(this.BtnEditRol_Click);
            // 
            // FrmRolAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 614);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.DgvData);
            this.Controls.Add(this.CbRol);
            this.Controls.Add(this.CbStatus);
            this.Controls.Add(this.TxtPwd);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtUserId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmRolAccess";
            this.Text = "Roles usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.ComboBox CbRolName;
        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.ComboBox CbRol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnSaveRol;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnEditRol;
        private System.Windows.Forms.CheckBox CbRolStatus;
        private System.Windows.Forms.TextBox TxtRolName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}