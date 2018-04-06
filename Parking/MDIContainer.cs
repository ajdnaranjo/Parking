﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parking.Utilities;
using Parking.Models;
using Parking.Repositories;

namespace Parking
{
    public partial class MDIContainer : Form
    {
        //public string AppUserName;

        public MDIContainer(string AppUserName)
        {
            InitializeComponent();
            RolAcces(AppUserName);
            var repo = new ConfigurationRepository();
            this.Text = repo.GetConfiguration().Name;

        }

        private void RolAcces(string AppUserName)
        {
            var repo = new AccessRepository();
            var result = repo.GetRolFormAccess(AppUserName);            

            foreach (var item in result)
            {
                if (((ToolStripMenuItem)tSMIFrmRegistry).Name == item.FormName)
                    ((ToolStripMenuItem)tSMIFrmRegistry).Enabled = true;
                if (((ToolStripMenuItem)tsMIFrmMonthlyPayment).Name == item.FormName)
                    ((ToolStripMenuItem)tsMIFrmMonthlyPayment).Enabled = true;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = new Process.FrmRegistry()
            {
                MdiParent = this
            };
            frm.Show();            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var frm = new Process.FrmMonthlyPayment()
            {
                MdiParent = this
            };
            frm.Show();
        }
    }
}
