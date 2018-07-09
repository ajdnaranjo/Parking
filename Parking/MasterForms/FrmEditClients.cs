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
                    CelPhone = TxtCelPhone.Text.Trim()
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
        }

        private void TxtPlate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
}
