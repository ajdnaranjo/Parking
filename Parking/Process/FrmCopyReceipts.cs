using Parking.Models;
using Parking.Repositories;
using Parking.Utilities;
using System;
using System.Windows.Forms;

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
            var receipt = new Receipts();
            var print = new PrintReceipts();

            if (CbEntry.Checked == true)
            {                
                var data = repo.GetRegistryByReciptNum(TxtReceipt.Text.Trim());
                var result = receipt.EntryReceipt(data.Plate, Globals.appUserID);
                print.PrintPDFs(result);

            }
            if (CbExit.Checked == true)
            {
                var data = repo.GetRegistryByReciptNum(TxtReceipt.Text.Trim());
                var result = receipt.ExitReceipt(data.Plate, Globals.appUserID);
                print.PrintPDFs(result);
            }
            else
                MessageBox.Show(Constants.MSG_NoSelectedOption);
            

        }

        private void TxtReceipt_Leave(object sender, EventArgs e)
        {
            var repo = new RegistryRepository();
            var data = repo.GetRegistryByReciptNum(TxtReceipt.Text.Trim());

            if (data != null) CbEntry.Enabled = true;
            else MessageBox.Show(Constants.MSG_NoRecordExist);
            if (data.ExitDate != null) CbExit.Enabled = true;
        }
    }
}
