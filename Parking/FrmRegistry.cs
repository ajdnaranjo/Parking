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

namespace Parking
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
                DateTime.Now.Second.ToString() ;
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

            if (e.KeyChar == Convert.ToChar(Keys.Enter) || e.KeyChar == Convert.ToChar(Keys.Tab))
            {
                lblIngreso.Text = DateTime.Now.ToString();

                var repo = new RegistryRepository();

                var reg = new Registry()
                {
                    Plate = txtPlate.Text.Trim(),
                    EntryDate = DateTime.Now
                };

                var data = repo.CheckEntryExit(reg);

                lblIngreso.Text = data.EntryDate.ToString();                

                if (data.ExitDate == null)
                {
                    /*TODO: Print receipt*/
                }
                else
                {
                    lblSalida.Text = data.ExitDate.ToString();
                    decimal totalPayment = (decimal)data.TotalPayment;
                    txtTotalPayment.Text = totalPayment.ToString("N0");
                    Days = data.Days;
                    Hours = data.Hours;
                    Minutes = data.Minutes;
                    txtPlate.Enabled = false;
                }
              
            }
        }

        private void txtPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateNumber(e);

            if (e.KeyChar == Convert.ToChar(Keys.Enter) || e.KeyChar == Convert.ToChar(Keys.Tab))
            {
                CalculateRefund();

                var repo = new RegistryRepository();

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


                var result = repo.CheckExit(check);

                /*TODO: Print receipt*/

                CleanForm();
            }
        }

        private void CalculateRefund()
        {
            var totalPayment = decimal.Parse(txtTotalPayment.Text.Trim());
            var payment = decimal.Parse(txtPayment.Text.Trim());
            var refund = payment - totalPayment;
            txtRefund.Text = refund.ToString("N0");
        }

        private void CleanForm()
        {
            txtPlate.Text = string.Empty;
            txtPlate.Enabled = true;
            txtPlate.Focus();
            txtTotalPayment.Text = string.Empty;
            txtPayment.Text = string.Empty;
            txtRefund.Text = string.Empty;
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
