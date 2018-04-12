namespace Parking.MasterForms
{
    partial class FrmConfiguration
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
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtConfigName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtConfigValue = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.CoonfigName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConfigValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            this.DgvData.AllowUserToDeleteRows = false;
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CoonfigName,
            this.ConfigValue});
            this.DgvData.Location = new System.Drawing.Point(38, 133);
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.Size = new System.Drawing.Size(644, 241);
            this.DgvData.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre Configuración:";
            // 
            // TxtConfigName
            // 
            this.TxtConfigName.Location = new System.Drawing.Point(174, 47);
            this.TxtConfigName.Name = "TxtConfigName";
            this.TxtConfigName.Size = new System.Drawing.Size(222, 20);
            this.TxtConfigName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor Configuración:";
            // 
            // TxtConfigValue
            // 
            this.TxtConfigValue.Location = new System.Drawing.Point(174, 76);
            this.TxtConfigValue.Name = "TxtConfigValue";
            this.TxtConfigValue.Size = new System.Drawing.Size(222, 20);
            this.TxtConfigValue.TabIndex = 4;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(421, 74);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // CoonfigName
            // 
            this.CoonfigName.DataPropertyName = "ConfigurationName";
            this.CoonfigName.HeaderText = "Nombre Config.";
            this.CoonfigName.Name = "CoonfigName";
            this.CoonfigName.ReadOnly = true;
            this.CoonfigName.Width = 200;
            // 
            // ConfigValue
            // 
            this.ConfigValue.DataPropertyName = "ConfigurationValue";
            this.ConfigValue.HeaderText = "Valor Config.";
            this.ConfigValue.Name = "ConfigValue";
            this.ConfigValue.ReadOnly = true;
            this.ConfigValue.Width = 400;
            // 
            // FrmConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 407);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtConfigValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtConfigName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvData);
            this.Name = "FrmConfiguration";
            this.Text = "FrmConfiguration";
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtConfigName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtConfigValue;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoonfigName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConfigValue;
    }
}