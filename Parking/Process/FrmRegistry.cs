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
using Parking.Utilities;

namespace Parking.Process
{
    public partial class FrmRegistry : Form
    {
        private int? Days, Hours, Minutes;

        public FrmRegistry()
        {
            InitializeComponent();
        }

        private void tHour_Tick(object sender, EventArgs e)
        {
            lblHour.Text = DateTime.Now.Hour.ToString() + ":" +
                DateTime.Now.Minute.ToString() + ":" +
                DateTime.Now.Second.ToString();
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
            e.KeyChar = Char.ToUpper(e.KeyChar);

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPlateKeypress();
            }
        }

        private void txtPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateNumber(e);

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (!string.IsNullOrEmpty(txtPlate.Text))
                {
                    txtPaymentKeypress();
                }
            }
        }

        private void txtPaymentKeypress()
        {
            CalculateRefund();

            var repo = new RegistryRepository();
            var repoUser = new UserRepository();

            var check = new Registry()
            {
                Plate = txtPlate.Text.Trim(),
                ExitDate = DateTime.Parse(lblSalida.Text),
                TotalPayment = decimal.Parse(txtTotalPayment.Text),
                Payment = decimal.Parse(txtPayment.Text.Trim()),
                Refund = decimal.Parse(txtRefund.Text),
                Days = Days,
                Hours = Hours,
                Minutes = Minutes
            };

            var mp = repoUser.GetMonthlyPaymentByPlate(check.Plate);

            if (mp == null)
            {
                var result = repo.CheckExit(check);

                var repoReceipts = new Receipts();
                var path = repoReceipts.EntryReceipt(result.Plate);
                var print = new PrintReceipts();
                var response = print.PrintPDFs(path);
            }
            else
            {
                check.MonthlyPaymentID = mp.MonthlyPaymentID;
                check.TotalPayment = 0;
                check.Payment = 0;
                check.Refund = 0;

                var result = repo.CheckExit(check);
            }

            CleanForm();
        }

        private void txtPlateKeypress()
        {
            lblIngreso.Text = DateTime.Now.ToString();

            var repo = new RegistryRepository();
            var repoUser = new UserRepository();

            var reg = new Registry()
            {
                Plate = txtPlate.Text.Trim(),
                EntryDate = DateTime.Now
            };

            var data = repo.CheckEntryExit(reg);

            lblIngreso.Text = data.EntryDate.ToString();
            var mp = repoUser.GetMonthlyPaymentByPlate(txtPlate.Text.Trim());

            if (data.ExitDate == null)
            {
                if (mp == null)
                {
                    var repoReceipts = new Receipts();
                    var path = repoReceipts.EntryReceipt(reg.Plate);
                    var print = new PrintReceipts();
                    var result = print.PrintPDFs(path);
                }
                else
                {
                    MessageBox.Show( "Usuario con mensualidad activa.");
                }

                CleanForm();
            }
            else
            {
                if (mp == null)
                {
                    lblSalida.Text = data.ExitDate.ToString();
                    decimal totalPayment = (decimal)data.TotalPayment;
                    txtTotalPayment.Text = totalPayment.ToString("N0");
                    Days = data.Days;
                    Hours = data.Hours;
                    Minutes = data.Minutes;
                    txtPlate.Enabled = false;
                }
                else
                {
                    lblMessage.Text = "Usuario con mensualidad activa.";
                    lblSalida.Text = data.ExitDate.ToString();
                    txtTotalPayment.Text = "0";
                    txtPayment.Text = "0";
                    Days = data.Days;
                    Hours = data.Hours;
                    Minutes = data.Minutes;
                    txtPlate.Enabled = false;
                }
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

        private void txtPlate_Leave(object sender, EventArgs e)
        {
            txtPlateKeypress();
        }

        private void CleanForm()
        {
            txtPlate.Text = string.Empty;
            txtPlate.Enabled = true;
            txtPlate.Focus();
            txtTotalPayment.Text = string.Empty;
            txtPayment.Text = string.Empty;
            txtRefund.Text = string.Empty;
            lblMessage.Text = string.Empty;
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
    }
}
