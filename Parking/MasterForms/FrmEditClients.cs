using Parking.Models;
using Parking.Repositories;
using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Parking.MasterForms
{
    public partial class FrmEditClient : Form
    {
        public FrmEditClient()
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


        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            var repo = new UserRepository();
            var result = repo.GetUserByPlateOrDocument(TxtSearch.Text.Trim());

            GvData.AutoGenerateColumns = false;
            GvData.DataSource = result;
        }

        private void GvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = GvData.CurrentRow;
            if (row.Cells[0].Value.ToString() != "")
            {
                var repo = new UserRepository();
                var data = repo.GetUserByPlate(row.Cells[0].Value.ToString());
                TxtDocument.Text = data.Document;
                TxtFullName.Text = data.Name;
                TxtCelPhone.Text = data.CelPhone;
                TxtPlate.Text = data.Plate;                
                CbDocType.SelectedValue = data.DocTypeID;
                CbIsActive.Checked = (bool)data.IsActive;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var repo = new UserRepository();

            if (ValidateForm())
            {
                var client = new Client()
                {
                    Plate = TxtPlate.Text.Trim(),
                    Document = TxtDocument.Text.Trim(),
                    DocTypeID = int.Parse(CbDocType.SelectedValue.ToString()),
                    Name = TxtFullName.Text.Trim(),
                    CelPhone = TxtCelPhone.Text.Trim(),
                    IsActive = CbIsActive.Checked
                };

                var result = repo.EditClient(client);
                if (result != null)
                {
                    MessageBox.Show(Constants.MSG_UpdateRecord);

                    CleanForm();
                }
            }
            else MessageBox.Show(Constants.MSG_ValidateForm);
            
        }

        private bool ValidateForm()
        {
            var flag = true;

            if (string.IsNullOrEmpty(TxtPlate.Text.Trim())) flag = false;

            return flag;
        }

        private void CleanForm()
        {
            TxtDocument.Text = string.Empty;
            TxtFullName.Text = string.Empty;
            TxtPlate.Text =  string.Empty;
            TxtCelPhone.Text = string.Empty;
            TxtSearch.Text = string.Empty;
            CbIsActive.Checked = false;
        }

        private void TxtPlate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void TxtFullName_KeyPress(object sender, KeyPressEventArgs e) => e.KeyChar = Char.ToUpper(e.KeyChar);

        private void TxtPlate_TextChanged(object sender, EventArgs e)
        {
            TxtPlate.Text = ValidatePlate(TxtPlate.Text.Trim());
            TxtPlate.Select(TxtPlate.Text.Length, 0);

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

        
    }
}
