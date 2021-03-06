﻿namespace Parking
{
    partial class MDIContainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIContainer));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIFrmRegistry = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMIFrmMonthlyPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmCopyReceipts = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsimCloseWorkShift = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMonthlyPayments = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiCloseWorkShiftCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIsInSite = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFrmConfiguration = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFrmRolAcces = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFrmUpdatePass = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmEditClient = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUpdatePlate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDeleteReceipt = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.tsmUpdatePrices = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.reportMenu,
            this.toolsMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1153, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMIFrmRegistry,
            this.tsMIFrmMonthlyPayment,
            this.TsmCopyReceipts,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(66, 20);
            this.fileMenu.Text = "&Procesos";
            // 
            // tSMIFrmRegistry
            // 
            this.tSMIFrmRegistry.Enabled = false;
            this.tSMIFrmRegistry.Name = "tSMIFrmRegistry";
            this.tSMIFrmRegistry.Size = new System.Drawing.Size(142, 22);
            this.tSMIFrmRegistry.Text = "&Registro";
            this.tSMIFrmRegistry.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // tsMIFrmMonthlyPayment
            // 
            this.tsMIFrmMonthlyPayment.Enabled = false;
            this.tsMIFrmMonthlyPayment.Name = "tsMIFrmMonthlyPayment";
            this.tsMIFrmMonthlyPayment.Size = new System.Drawing.Size(142, 22);
            this.tsMIFrmMonthlyPayment.Text = "&Mensualidad";
            this.tsMIFrmMonthlyPayment.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // TsmCopyReceipts
            // 
            this.TsmCopyReceipts.Enabled = false;
            this.TsmCopyReceipts.Name = "TsmCopyReceipts";
            this.TsmCopyReceipts.Size = new System.Drawing.Size(142, 22);
            this.TsmCopyReceipts.Text = "&Copia";
            this.TsmCopyReceipts.Click += new System.EventHandler(this.TsmCopyReceipts_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(139, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // reportMenu
            // 
            this.reportMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsimCloseWorkShift,
            this.tsmiMonthlyPayments,
            this.TsmiCloseWorkShiftCopy,
            this.tsmiIsInSite});
            this.reportMenu.Name = "reportMenu";
            this.reportMenu.Size = new System.Drawing.Size(65, 20);
            this.reportMenu.Text = "&Reportes";
            // 
            // tsimCloseWorkShift
            // 
            this.tsimCloseWorkShift.Enabled = false;
            this.tsimCloseWorkShift.Name = "tsimCloseWorkShift";
            this.tsimCloseWorkShift.Size = new System.Drawing.Size(176, 22);
            this.tsimCloseWorkShift.Text = "&Cierre de turno";
            this.tsimCloseWorkShift.Click += new System.EventHandler(this.tsimCloseWorkShift_Click);
            // 
            // tsmiMonthlyPayments
            // 
            this.tsmiMonthlyPayments.Enabled = false;
            this.tsmiMonthlyPayments.Name = "tsmiMonthlyPayments";
            this.tsmiMonthlyPayments.Size = new System.Drawing.Size(176, 22);
            this.tsmiMonthlyPayments.Text = "&Mensualidades";
            this.tsmiMonthlyPayments.Click += new System.EventHandler(this.tsmiMonthlyPayments_Click);
            // 
            // TsmiCloseWorkShiftCopy
            // 
            this.TsmiCloseWorkShiftCopy.Enabled = false;
            this.TsmiCloseWorkShiftCopy.Name = "TsmiCloseWorkShiftCopy";
            this.TsmiCloseWorkShiftCopy.Size = new System.Drawing.Size(176, 22);
            this.TsmiCloseWorkShiftCopy.Text = "Copia cierre turno";
            this.TsmiCloseWorkShiftCopy.Click += new System.EventHandler(this.TsmiCloseWorkShiftCopy_Click);
            // 
            // tsmiIsInSite
            // 
            this.tsmiIsInSite.Name = "tsmiIsInSite";
            this.tsmiIsInSite.Size = new System.Drawing.Size(176, 22);
            this.tsmiIsInSite.Text = "Lista motos en sitio";
            this.tsmiIsInSite.Click += new System.EventHandler(this.tsmiIsInSite_Click);
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFrmConfiguration,
            this.tsmiFrmRolAcces,
            this.tsmiFrmUpdatePass,
            this.TsmEditClient,
            this.tsmUpdatePlate,
            this.tsmDeleteReceipt,
            this.tsmUpdatePrices});
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(69, 20);
            this.toolsMenu.Text = "&Opciones";
            // 
            // tsmiFrmConfiguration
            // 
            this.tsmiFrmConfiguration.Enabled = false;
            this.tsmiFrmConfiguration.Name = "tsmiFrmConfiguration";
            this.tsmiFrmConfiguration.Size = new System.Drawing.Size(180, 22);
            this.tsmiFrmConfiguration.Text = "&Configuracion";
            this.tsmiFrmConfiguration.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // tsmiFrmRolAcces
            // 
            this.tsmiFrmRolAcces.Enabled = false;
            this.tsmiFrmRolAcces.Name = "tsmiFrmRolAcces";
            this.tsmiFrmRolAcces.Size = new System.Drawing.Size(180, 22);
            this.tsmiFrmRolAcces.Text = "&Roles Usuario";
            this.tsmiFrmRolAcces.Click += new System.EventHandler(this.tsmiFrmRolAcces_Click);
            // 
            // tsmiFrmUpdatePass
            // 
            this.tsmiFrmUpdatePass.Enabled = false;
            this.tsmiFrmUpdatePass.Name = "tsmiFrmUpdatePass";
            this.tsmiFrmUpdatePass.Size = new System.Drawing.Size(180, 22);
            this.tsmiFrmUpdatePass.Text = "Cambio contraseña";
            this.tsmiFrmUpdatePass.Click += new System.EventHandler(this.tsmiFrmUpdatePass_Click);
            // 
            // TsmEditClient
            // 
            this.TsmEditClient.Enabled = false;
            this.TsmEditClient.Name = "TsmEditClient";
            this.TsmEditClient.Size = new System.Drawing.Size(180, 22);
            this.TsmEditClient.Text = "&Editar Cliente";
            this.TsmEditClient.Click += new System.EventHandler(this.TsmEditClient_Click);
            // 
            // tsmUpdatePlate
            // 
            this.tsmUpdatePlate.Enabled = false;
            this.tsmUpdatePlate.Name = "tsmUpdatePlate";
            this.tsmUpdatePlate.Size = new System.Drawing.Size(180, 22);
            this.tsmUpdatePlate.Text = "Actualizar Placa";
            this.tsmUpdatePlate.Click += new System.EventHandler(this.tsmUpdatePlate_Click);
            // 
            // tsmDeleteReceipt
            // 
            this.tsmDeleteReceipt.Enabled = false;
            this.tsmDeleteReceipt.Name = "tsmDeleteReceipt";
            this.tsmDeleteReceipt.Size = new System.Drawing.Size(180, 22);
            this.tsmDeleteReceipt.Text = "Eliminar Recibo";
            this.tsmDeleteReceipt.Click += new System.EventHandler(this.tsmDeleteReceipt_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.helpMenu.Enabled = false;
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 20);
            this.helpMenu.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("indexToolStripMenuItem.Image")));
            this.indexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem.Image")));
            this.searchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(165, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.aboutToolStripMenuItem.Text = "&About ... ...";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 824);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1153, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(319, 3);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(52, 17);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "label2";
            // 
            // tsmUpdatePrices
            // 
            this.tsmUpdatePrices.Enabled = false;
            this.tsmUpdatePrices.Name = "tsmUpdatePrices";
            this.tsmUpdatePrices.Size = new System.Drawing.Size(180, 22);
            this.tsmUpdatePrices.Text = "Actualizar Precios";
            this.tsmUpdatePrices.Click += new System.EventHandler(this.tsmUpdatePrices_Click);
            // 
            // MDIContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 846);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIContainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDIContainer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MDIContainer_FormClosed);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiFrmConfiguration;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem tSMIFrmRegistry;
        private System.Windows.Forms.ToolStripMenuItem tsMIFrmMonthlyPayment;
        private System.Windows.Forms.ToolStripMenuItem tsmiFrmRolAcces;
        private System.Windows.Forms.ToolStripMenuItem reportMenu;
        private System.Windows.Forms.ToolStripMenuItem tsimCloseWorkShift;
        private System.Windows.Forms.ToolStripMenuItem tsmiFrmUpdatePass;
        private System.Windows.Forms.ToolStripMenuItem tsmiMonthlyPayments;
        private System.Windows.Forms.ToolStripMenuItem TsmCopyReceipts;
        private System.Windows.Forms.ToolStripMenuItem TsmEditClient;
        private System.Windows.Forms.ToolStripMenuItem TsmiCloseWorkShiftCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiIsInSite;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ToolStripMenuItem tsmUpdatePlate;
        private System.Windows.Forms.ToolStripMenuItem tsmDeleteReceipt;
        private System.Windows.Forms.ToolStripMenuItem tsmUpdatePrices;
    }
}



