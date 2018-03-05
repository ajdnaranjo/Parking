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
using Parking.Models;

namespace Parking.Process
{
    public partial class FrmMonthlyPayment : Form
    {
        public FrmMonthlyPayment()
        {
            InitializeComponent();
            InitialLoad();
        }

        private void InitialLoad()
        {
            var repo = new UserRepository();
            var data = repo.GetDocTypes();

            data.Add(new DocType { DocTypeID = -1, Description = "Seleccionar" });
            data.OrderBy(z => z.DocTypeID);

            CbDocType.DataSource = data;
            CbDocType.ValueMember = "DocTypeID";
            CbDocType.DisplayMember = "Description";

            TxtTotalPayment.Text =  repo.GetMonthlyPayment().Value.ToString("N0");

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var repo = new RegistryRepository();
            var repoUser = new UserRepository();

            var data = new MonthlyPaymentDto()
            {
                Document = TxtDocument.Text.Trim(),
                DocTypeId = int.Parse(CbDocType.SelectedValue.ToString()),
                Name = TxtName.Text,
                Celphone = TxtCelPhone.Text,
                Plate = TxtPlate.Text,
                PaidValue = decimal.Parse(TxtPayment.Text),
                TotalPayment = decimal.Parse(TxtTotalPayment.Text),
                Refund = decimal.Parse(TxtRefund.Text),
                PaymentDate = DateTime.Now,
                ExpirationDate = DateTime.Now.AddMonths(1)
            };

            var mp = repoUser.ValidMonthlyPayment(data.Plate);
            var result = new MonthlyPaymentDto(); ;
            if (mp == null)
            {
                 result = repo.SaveMonthlyPayment(data);
            }
            else {

                data.PaymentDate = mp.ExpirationDate.AddDays(1);
                data.ExpirationDate = data.PaymentDate.AddMonths(1);                

                result = repo.SaveMonthlyPayment(data);
            }

            if (result.MonthlyPaymentId > 0) MessageBox.Show("Mensualidad guardada exitosamente.");

            CleanForm();
        }

        private void TxtDocument_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                FillUser(TxtDocument.Text.Trim());
            }
        }

        private void TxtPlate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                var repo = new UserRepository();
                var result = repo.GetUserByPlate(TxtPlate.Text.Trim());

                if (result != null)
                {
                    TxtDocument.Text = result.Document;
                    TxtName.Text = result.Name;
                    CbDocType.SelectedValue = result.DocTypeID;
                    TxtCelPhone.Text = result.CelPhone;
                }

                TxtPayment.Focus();
            }
        }

        private void TxtPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateNumber(e);

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BtnSave.Focus();
            }
        }

        private void TxtPayment_TextChanged(object sender, EventArgs e)
        {
            if (TxtTotalPayment.Text.Trim() != "" && TxtPayment.Text.Trim() != "") CalculateRefund();
        }

        private void CalculateRefund()
        {
            var totalPayment = decimal.Parse(TxtTotalPayment.Text.Trim());
            var payment = decimal.Parse(TxtPayment.Text.Trim());
            var refund = payment - totalPayment;
            TxtRefund.Text = refund.ToString("N0");
        }

        private void FillUser(string document)
        {
            var repo = new UserRepository();
            var result = repo.GetUserById(document);

            CbDocType.SelectedValue = result.DocTypeID;
            TxtName.Text = result.Name;
            TxtCelPhone.Text = result.CelPhone;
            TxtPlate.Focus();
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

        private void CleanForm()
        {
            TxtDocument.Text = string.Empty;
            TxtName.Text = string.Empty;
            TxtCelPhone.Text = string.Empty;
            TxtPlate.Text = string.Empty;
            TxtPayment.Text = string.Empty;
        }
    }
}
