using Parking.Models;
using Parking.Repositories;
using Parking.Utilities;
using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

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

            var repoPayments = new MonthlyRepository();

            var result = repoPayments.GetLongTermPayments();

            var isAdmin = repo.GetAdmin(Globals.appUserID);

            result.Add(new PaymentMethod { PaymentMethodID = -1, Description = "Seleccionar" });
            if (isAdmin != null) result.Add(new PaymentMethod { PaymentMethodID = 100, Description = "Eliminar" });

            result.OrderBy(z => z.PaymentMethodID);

            CbPaymentType.DataSource = result;
            CbPaymentType.ValueMember = "PaymentMethodID";
            CbPaymentType.DisplayMember = "Description";
            CbPaymentType.SelectedValue = -1;

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
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
                    StartDate = DateTime.Now,                   
                    IsWorkShiftClosed = false,
                    PaymentMethodID = (int)CbPaymentType.SelectedValue
                };

                if (data.PaymentMethodID == 5) data.ExpirationDate = DateTime.Now.AddMonths(1);
                if (data.PaymentMethodID == 6) data.ExpirationDate = DateTime.Now.AddDays(15);

                var mp = repoUser.ValidMonthlyPayment(data.Plate);
                var result = new MonthlyPaymentDto(); 
                if (mp == null)
                {
                    result = repo.SaveMonthlyPayment(data, Globals.appUserID);

                }
                else
                {
                    data.StartDate = mp.ExpirationDate;                    
                    if (data.PaymentMethodID == 5) data.ExpirationDate = data.StartDate.AddMonths(1);
                    if (data.PaymentMethodID == 6) data.ExpirationDate = data.StartDate.AddDays(15);

                    result = repo.SaveMonthlyPayment(data, Globals.appUserID);
                }

                repo.DeletePaymentByPlate(data.Plate, Globals.appUserID);

                var repoReceipts = new Receipts();
                var repoPrint = new PrintReceipts();
                var path = repoReceipts.MonthlyPaymentReceipt(result.MonthlyPaymentID, Globals.appUserID);
                repoPrint.PrintPDFs(path);

                MessageBox.Show(string.Format("{0} guardada exitosamente.", result.PaymentDescriptiion));

                CleanForm();
            }
           
        }

        private bool ValidateForm()
        {
            var flag = true;

            if (string.IsNullOrEmpty(TxtPayment.Text.Trim()))
            {
                MessageBox.Show("Debe ingresar un pago.");
                flag = false;
            }
            if (CbPaymentType.SelectedValue.ToString() == "-1")
            {
                MessageBox.Show("Debe seleccionar un tipo de pago.");
                flag = false;
            }
            if (string.IsNullOrEmpty(TxtPlate.Text.Trim()))
            {
                MessageBox.Show("Debe ingresar una Placa.");
                flag = false;
            }

            return flag;
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
                FillUserByPlate(TxtPlate.Text.Trim());
                CbPaymentType.Focus();
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
            if (!string.IsNullOrEmpty(document))
            {
                var repo = new UserRepository();
                var result = repo.GetUserById(document);

                if (result != null)
                {
                    CbDocType.SelectedValue = result.DocTypeID;
                    TxtName.Text = result.Name;
                    TxtCelPhone.Text = result.CelPhone;
                    TxtPlate.Text = result.Plate;
                    TxtPlate.Focus();
                }
                else {
                    CleanForm();
                    TxtDocument.Text = document;
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

        private void CleanForm()
        {
            TxtDocument.Text = string.Empty;
            TxtName.Text = string.Empty;
            TxtCelPhone.Text = string.Empty;
            TxtPlate.Text = string.Empty;
            TxtPayment.Text = string.Empty;
            TxtRefund.Text = string.Empty;
            CbPaymentType.SelectedValue = -1;
        }

        private void TxtDocument_Leave(object sender, EventArgs e)
        {
            FillUser(TxtDocument.Text.Trim());
        }

        private void TxtPlate_Leave(object sender, EventArgs e)
        {
            FillUserByPlate(TxtPlate.Text.Trim());

            TxtPayment.Focus();
        }

        private void FillUserByPlate(string plate)
        {
            var repo = new UserRepository();
            var result = repo.GetUserByPlate(plate);

            if (result != null)
            {
                TxtDocument.Text = result.Document;
                TxtName.Text = result.Name;
                CbDocType.SelectedValue = result.DocTypeID;
                TxtCelPhone.Text = result.CelPhone;
            }
            else
            {
               // CleanForm();
                TxtPlate.Text = plate;
            }

            TxtPayment.Focus();
        }

        private void CbPaymentType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (CbPaymentType.SelectedValue.ToString() != "-1")
            {
                if (CbPaymentType.SelectedValue.ToString() == "100")
                {
                    var repo = new UserRepository();
                    var isAdmin = repo.GetAdmin(Globals.appUserID);

                    if (isAdmin != null)
                    {
                        try
                        {
                            if (MessageBox.Show("Esta seguro que desea inactivar mensualidad del usuario seleccionado?", "Mensualidad", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                var result = repo.InactiveClient(new Client { Plate = TxtPlate.Text.Trim(), IsActive = false });

                                MessageBox.Show("La mensualidad del usuario ha sido inactivada correctamente");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else{
                        MessageBox.Show("Debe ser un administrador para eliminar una mensualidad.");
                    }
                }
                else
                {
                    var repo = new MonthlyRepository();
                    var result = repo.GetPaymentByID((int)CbPaymentType.SelectedValue);

                    TxtTotalPayment.Text = result.Value.ToString("N0");
                    TxtPayment.Enabled = true;
                    TxtPayment.Focus();
                }
            }
            else TxtTotalPayment.Text = "0";
        }
         

        private void TxtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private string ValidatePlate(string text)
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

        private void TxtPlate_TextChanged(object sender, EventArgs e)
        {
            TxtPlate.Text = ValidatePlate(TxtPlate.Text.Trim());
            TxtPlate.Select(TxtPlate.Text.Length, 0);
        }
    }
}
