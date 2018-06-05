using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parking.Repositories;

namespace Parking.Process
{
    public partial class FrmCopyReceipts : Form
    {
        public FrmCopyReceipts()
        {
            InitializeComponent();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            var repo = new RegistryRepository();
            var data = repo.GetRegistryByReciptNum(TxtReceipt.Text.Trim());

            if (data != null) CbEntry.Enabled = true;
            if (data.ExitDate != null) CbExit.Enabled = true;
            

        }
    }
}
