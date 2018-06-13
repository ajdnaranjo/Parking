using System;
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

        public MDIContainer(string AppUserName)
        {
            InitializeComponent();

            var secureRepo = new SecurityRepository();

            var userID = secureRepo.GetUserID(AppUserName);
            Globals.appUserID = userID;

            RolAccess(Globals.appUserID);
            var repo = new ConfigurationRepository();
            this.Text = repo.GetConfiguration().Name;

        }

        private void RolAccess(int AppUserID)
        {
            var repo = new SecurityRepository();
            var result = repo.GetRolFormAccess(AppUserID);            

            foreach (var item in result)
            {
                if (((ToolStripMenuItem)tSMIFrmRegistry).Name == item.FormName)
                    ((ToolStripMenuItem)tSMIFrmRegistry).Enabled = true;
                if (((ToolStripMenuItem)tsMIFrmMonthlyPayment).Name == item.FormName)
                    ((ToolStripMenuItem)tsMIFrmMonthlyPayment).Enabled = true;
                if (((ToolStripMenuItem)tsmiFrmConfiguration).Name == item.FormName)
                    ((ToolStripMenuItem)tsmiFrmConfiguration).Enabled = true;
                if (((ToolStripMenuItem)tsmiFrmRolAcces).Name == item.FormName)
                    ((ToolStripMenuItem)tsmiFrmRolAcces).Enabled = true;
                if (((ToolStripMenuItem)tsimCloseWorkShift).Name == item.FormName)
                    ((ToolStripMenuItem)tsimCloseWorkShift).Enabled = true;
                if (((ToolStripMenuItem)tsmiFrmUpdatePass).Name == item.FormName)
                    ((ToolStripMenuItem)tsmiFrmUpdatePass).Enabled = true;
                if (((ToolStripMenuItem)tsmiMonthlyPayments).Name == item.FormName)
                    ((ToolStripMenuItem)tsmiMonthlyPayments).Enabled = true;
                if (((ToolStripMenuItem)TsmCopyReceipts).Name == item.FormName)
                    ((ToolStripMenuItem)TsmCopyReceipts).Enabled = true;
                if (((ToolStripMenuItem)TsmEditClient).Name == item.FormName)
                    ((ToolStripMenuItem)TsmEditClient).Enabled = true;
                
            }            
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Globals.appUserID = 0;
            Application.Exit();
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

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new MasterForms.FrmConfiguration()
            {
                MdiParent = this
            };
            frm.Show();
        }

        private void tsimCloseWorkShift_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea realizar el cierre de turno?", "Cierre turno", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CloseWorkShift();

                Globals.appUserID = 0;
                Application.Exit();
            }
        }

        private void tsmiFrmUpdatePass_Click(object sender, EventArgs e)
        {
            var frm = new Process.FrmUpdatePass()
            {
                MdiParent = this
            };
            frm.Show();
        }

        private void tsmiMonthlyPayments_Click(object sender, EventArgs e)
        {
            var frm = new Reports.FrmMonthlyPayments()
            {
                MdiParent = this
            };
            frm.Show();
        }

        private void CloseWorkShift()
        {
            var repo = new ReportRepository();
            var repoReceipts = new Receipts();
            var data = repo.CloseWorkShift(Globals.appUserID);
            var path = repoReceipts.CloseWorkShift(data);
            var repoPrint = new PrintReceipts();
            repoPrint.PrintPDFs(path);
        }

        private void tsmiFrmRolAcces_Click(object sender, EventArgs e)
        {
            var frm = new MasterForms.FrmRolAccess()
            {
                MdiParent = this
            };
            frm.Show();
        }

        private void TsmCopyReceipts_Click(object sender, EventArgs e)
        {
            var frm = new Process.FrmCopyReceipts()
            {
                MdiParent = this
            };
            frm.Show();
        }

        private void MDIContainer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
