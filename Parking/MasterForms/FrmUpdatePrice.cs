using Parking.Repositories;
using System;
using System.Windows.Forms;
using System.Reflection;

namespace Parking.MasterForms
{
    public partial class FrmUpdatePrice : Form
    {
        public FrmUpdatePrice()
        {
            InitializeComponent();

            var repo = new ConfigurationRepository();

            var result = repo.GetPaymentMethods();

            cbPaymentMethods.DataSource = result;
            cbPaymentMethods.DisplayMember = "Description";
        }

        private void cbPaymentMethods_SelectedValueChanged(object sender, EventArgs e)
        {
            object value = cbPaymentMethods.SelectedValue;
            PropertyInfo pi = value.GetType().GetProperty("Value");
            decimal result = (decimal)(pi.GetValue(value, null));
            txtValue.Text = result.ToString("N0");             
            pi = value.GetType().GetProperty("PaymentMethodID");
            int resultID = (int)(pi.GetValue(value, null));
            LblPaymentID.Text = resultID.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var repo = new ConfigurationRepository();
            var result = repo.UpdatePayment(int.Parse(LblPaymentID.Text), decimal.Parse(txtValue.Text.Trim()));
            if (result)
            {
                MessageBox.Show("El registro se actualizó correctamente.");
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

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateNumber(e);
        }
    }
}
