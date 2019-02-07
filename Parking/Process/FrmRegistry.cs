using Parking.Repositories;
using Parking.Utilities;
using System;
using System.Windows.Forms;
using Parking.Models;
using System.Text.RegularExpressions;

namespace Parking.Process
{
    public partial class FrmRegistry : Form
    {
        private int? Days, Hours, Minutes;


        public FrmRegistry()
        {
            InitializeComponent();
            LoadLastMovements();
        }

        private void tHour_Tick(object sender, EventArgs e)
        {
            TickLoad();
        }

        private void TickLoad()
        {
            lblHour.Text = DateTime.Now.Hour.ToString() + ":" +
            DateTime.Now.Minute.ToString() + ":" +
            DateTime.Now.Second.ToString();

            //LoadLastMovements();
        }

        private void LoadLastMovements()
        {
            var repo = new RegistryRepository();
            DgvLastMovements.AutoGenerateColumns = false;
            DgvLastMovements.DataSource = repo.GetLastRegistryMovements();
        }

        private void txtPayment_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTotalPayment.Text.Trim()) && !string.IsNullOrEmpty(txtPayment.Text.Trim()))
            {
                CalculateRefund();
            }
        }

        private void txtPlate_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.KeyChar = char.ToUpper(e.KeyChar);

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                var repo = new MonthlyRepository();
                var result = repo.GetMonthlyPaymentByPlate(txtPlate.Text.Trim());

                if (result == null)
                {
                    GetDayPayment();
                }
                else 
                {
                    CbDayPayment.Enabled = false;
                    TxtLocker.Focus();
                }
            }
        }

        private void txtPlate_Leave(object sender, EventArgs e)
        {
            GetDayPayment();
        }

        private void GetDayPayment()
        {
            var lenght = txtPlate.TextLength;
            if (lenght >= 5)
            {
                if (txtPlate.Text.Trim() != string.Empty)
                {
                    var repo = new RegistryRepository();
                    var result = repo.GetDayPayment(txtPlate.Text);

                    if (result != null) CbDayPayment.Checked = (bool)result.DayPayment;
                }

                CbDayPayment.Focus();
            }
        }

        private void txtPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateNumber(e);

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (!string.IsNullOrEmpty(txtPlate.Text))
                {
                    if (!string.IsNullOrEmpty(txtPayment.Text.Trim()))
                    {
                        if (decimal.Parse(txtPayment.Text) < decimal.Parse(txtTotalPayment.Text))
                        {
                            MessageBox.Show(Constants.MSG_PaidLess);
                        }
                        else
                        {
                            txtPaymentKeypress();
                        }
                    }
                    else
                    {
                        MessageBox.Show(Constants.MSG_FillPayment);
                        txtPayment.Focus();
                    }
                }
            }
        }

        private void txtPaymentKeypress()
        {            

            if (!string.IsNullOrEmpty(txtPayment.Text.Trim()))
            {
                CalculateRefund();

                var repo = new RegistryRepository();
                var repoUser = new UserRepository();
                var repoReceipts = new Receipts();

                var check = new Registry()
                {
                    Plate = txtPlate.Text.Trim(),
                    ExitDate = DateTime.Parse(lblSalida.Text),
                    TotalPayment = decimal.Parse(txtTotalPayment.Text),
                    Payment = decimal.Parse(txtPayment.Text.Trim()),
                    Refund = decimal.Parse(txtRefund.Text),
                    Days = Days,
                    Hours = Hours,
                    Minutes = Minutes,
                    Locker = int.Parse(TxtLocker.Text.Trim()) > 0 ? int.Parse(TxtLocker.Text.Trim()) : 0,
                    DayPayment = CbDayPayment.Checked                    
                };

                var mp = repoUser.GetMonthlyPaymentByPlate(check.Plate);

                if (mp == null)
                {
                    bool flag = false;
                    //if (check.DayPayment == true) flag = true;

                    var result = repo.CheckExit(check, Globals.appUserID, flag);
                    
                    var path = repoReceipts.ExitReceipt(result.Plate, Globals.appUserID);
                    var print = new PrintReceipts();
                    var response = print.PrintPDFs(path);
                }
                else
                {                    
                    check.Plate = mp.Plate;
                    check.TotalPayment = 0;
                    check.Payment = 0;
                    check.Refund = 0;

                    var result = repo.CheckExit(check, Globals.appUserID);

                    var date = mp.ExpirationDate.Subtract(DateTime.Now);
                    var repoConfig = new ConfigurationRepository();                  

                    if (date.Days <= Globals.ConfigGlobal.MonthlyMessageDays)
                    {
                        var path = repoReceipts.MonthlyPaymentExpirationReceipt(mp.MonthlyPaymentID, Globals.appUserID);
                        var print = new PrintReceipts();
                        var response = print.PrintPDFs(path);
                        
                    }
                }

                CleanForm();
                txtPlate.Focus();
                LoadLastMovements();
            }
        }

        private void CalculateRefund()
        {
            if (!string.IsNullOrEmpty(txtPayment.Text))
            {
                var totalPayment = decimal.Parse(txtTotalPayment.Text.Trim());
                var payment = decimal.Parse(txtPayment.Text.Trim());
                var refund = payment - totalPayment;
                txtRefund.Text = refund.ToString("N0");
            }
        }


        private void CleanForm()
        {
            txtPlate.Text = string.Empty;
            txtPlate.Enabled = true;
            txtPlate.Focus();
            txtTotalPayment.Text = string.Empty;
            txtPayment.Text = string.Empty;
            txtRefund.Text = string.Empty;
            TxtLocker.Text = "0";
            TxtLocker.Enabled = true;
            CbDayPayment.Checked = false;
            lblIngreso.Text = string.Empty;
            lblSalida.Text = string.Empty;
           // CbDayPayment.Enabled = true;
        }

        private void txtPlate_TextChanged(object sender, EventArgs e)
        {
            txtPlate.Text = ValidateNumbersLetters(txtPlate.Text.Trim());
            txtPlate.Select(txtPlate.Text.Length, 0);
            //txtPlate.Text = ValidateNumbersLetters(txtPlate.Text);
            
        }

        private void TxtLocker_KeyPress(object sender, KeyPressEventArgs e)

        {
            ValidateNumber(e);

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                CheckEntryExit();
            }
        }

        private void CbDayPayment_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPlate.Enabled == false)
            {
              //  CbDayPayment.Enabled = false;
                CheckEntryExit();
            }
        }

        private void CbDayPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtLocker.Focus();
            }
        }

        private void CheckEntryExit()

        {           
            if (txtPlate.Text.Trim() != string.Empty)
            {
                lblIngreso.Text = DateTime.Now.ToString();

                var repo = new RegistryRepository();
                var repoUser = new UserRepository();

                var reg = new Registry()
                {
                    Plate = txtPlate.Text.Trim(),
                    EntryDate = DateTime.Now,
                    IsWorkShiftClosed = false,
                    Locker = string.IsNullOrEmpty(TxtLocker.Text.Trim()) ? 0 : int.Parse(TxtLocker.Text),
                    DayPayment = CbDayPayment.Checked
                };

                var data = repo.CheckEntryExit(reg, Globals.appUserID);

                lblIngreso.Text = data.EntryDate.ToString();
                var mp = repoUser.GetMonthlyPaymentByPlate(txtPlate.Text.Trim());

                if (data.ExitDate == null && reg.DayPayment == false)
                {
                    if (mp == null)
                    {
                        var repoReceipts = new Receipts();
                        var path = repoReceipts.EntryReceipt(reg.Plate, Globals.appUserID);
                        var print = new PrintReceipts();
                        var result = print.PrintPDFs(path);
                    }
                    else
                    {
                        MessageBox.Show(string.Format(Constants.MSG_ActiveMonhtlyPayment, mp.PaymentDescriptiion));
                    }

                    txtPlate.Focus();
                    CleanForm();
                    LoadLastMovements();
                }
                else
                {
                    if (mp == null)
                    {
                        if (data.DayPayment == true && data.Hours <= 12 && data.ModifiedBy != null)
                        {
                            DialogResult result = MessageBox.Show(Constants.MSG_DayPayment, Constants.MSG_OK, MessageBoxButtons.OK);
                            if (result == DialogResult.OK)
                            {
                                repo.UpdateEntryExitDaypayment(data.RegistryID, Globals.appUserID);

                                CleanForm();
                            }

                        }
                        else
                        {
                            lblIngreso.Text = data.EntryDate.ToString();
                            lblSalida.Text = data.ExitDate.ToString();
                            decimal totalPayment = (decimal)data.TotalPayment;
                            txtTotalPayment.Text = totalPayment.ToString("N0");
                            Days = data.Days;
                            Hours = data.Hours;
                            Minutes = data.Minutes;
                            txtPlate.Enabled = false;
                            TxtLocker.Text = string.IsNullOrEmpty(data.Locker.ToString()) ? "0" : data.Locker.ToString();
                            TxtLocker.Enabled = false;
                            txtPayment.Text = "0";
                            txtRefund.Text = "0";
                        }
                    }
                    else
                    {
                        MessageBox.Show(string.Format(Constants.MSG_ActiveMonhtlyPayment, mp.PaymentDescriptiion));
                        lblSalida.Text = data.ExitDate.ToString();
                        txtTotalPayment.Text = "0";
                        txtPayment.Text = "0";
                        Days = data.Days;
                        Hours = data.Hours;
                        Minutes = data.Minutes;
                        txtPlate.Enabled = false;
                        TxtLocker.Text = string.IsNullOrEmpty(data.Locker.ToString()) ? "0" : data.Locker.ToString();
                        TxtLocker.Enabled = false;
                        txtPayment.Text = "0";
                        txtRefund.Text = "0";
                    }

                    txtPayment.Focus();
                }
            }
        }

        private bool ValidateNumber(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar) == true)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            return e.Handled;
        }

        private string ValidateNumbersLetters(string text)
        {
            var flag = false;           

            var length = text.Length;

            switch (length)
            {
                case 0:
                    flag = true;
                    break;
                case 1:
                    if (Regex.IsMatch(text, "[A-Z]{1}")) flag = true;
                    break;
                case 2:
                    if (Regex.IsMatch(text, "[A-Z]{2}")) flag = true;
                    break;
                case 3:
                    if (Regex.IsMatch(text, "[A-Z]{3}")) flag = true;
                    break;
                case 4:
                    if (Regex.IsMatch(text, "[A-Z]{3}[0-9]{1}")) flag = true;
                    break;
                case 5:
                    if (Regex.IsMatch(text, "[A-Z]{3}[0-9]{2}")) flag = true;
                    break;
                case 6:
                    if (Regex.IsMatch(text, "[A-Z]{3}[0-9]{2}[A-Z]{1}")) flag = true;
                    break;             
            }

            if (flag)
                return text;
            else
                return text.Remove(text.Length - 1);            
                  
        }
    }
}
