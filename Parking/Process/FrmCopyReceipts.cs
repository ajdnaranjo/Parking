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

            if (CbEntry.Checked == false && CbExit.Checked == false && cbMonthly.Checked == false)
                MessageBox.Show(Constants.MSG_NoSelectedOption);
            else
            {

                if (CbEntry.Checked == true)
                {
                    var eData = repo.GetLastRegistryReceiptByPlate(TxtReceipt.Text.Trim());
                    var data = repo.GetRegistryByReciptNum(eData.RegistryID);
                    var result = receipt.EntryReceipt(data.Plate, Globals.appUserID);
                    print.PrintPDFs(result);

                }
                if (CbExit.Checked == true)
                {
                    var eData = repo.GetLastRegistryReceiptByPlate(TxtReceipt.Text.Trim());
                    var data = repo.GetRegistryByReciptNum(eData.RegistryID);
                    var result = receipt.ExitReceipt(data.Plate, Globals.appUserID);
                    print.PrintPDFs(result);
                }
                if (cbMonthly.Checked == true)
                {
                    var eData = repo.GetLasMonthlyPaymentReceiptByPlate(TxtReceipt.Text.Trim());
                    var result = receipt.MonthlyPaymentReceipt(eData.MonthlyPaymentID, Globals.appUserID);
                    print.PrintPDFs(result);
                }

                MessageBox.Show(Constants.MSG_CopyReceipts);

                ClearForm();
            }
        }

        private void ClearForm()
        {
            TxtReceipt.Text = string.Empty;
            CbEntry.Enabled = false;
            CbEntry.Checked = false;
            CbExit.Enabled = false;
            CbExit.Checked = false;
            cbMonthly.Enabled = false;
            cbMonthly.Checked = false;
        }

        private void TxtReceipt_Leave(object sender, EventArgs e)
        {
            var repo = new RegistryRepository();

            var data = repo.GetLastRegistryReceiptByPlate(TxtReceipt.Text.Trim());

            if (data != null)
            {
                CbEntry.Enabled = true;
                if (data.ExitDate != null) CbExit.Enabled = true;
                cbMonthly.Enabled = false;
                cbMonthly.Checked = false;
            }
            else
            {
                var eData = repo.GetLasMonthlyPaymentReceiptByPlate(TxtReceipt.Text.Trim());

                if (eData != null)
                {
                    CbEntry.Enabled = false;
                    CbEntry.Checked = false;
                    CbExit.Enabled = false;
                    CbExit.Checked = false;
                    cbMonthly.Enabled = true;
                    cbMonthly.Checked = true;
                }
                else MessageBox.Show(Constants.MSG_NoRecordExist);
            }
        }

        private void TxtReceipt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
}
