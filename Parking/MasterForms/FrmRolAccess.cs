using Parking.Models;
using Parking.Repositories;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Parking.MasterForms
{
    public partial class FrmRolAccess : Form
    {
        public FrmRolAccess()
        {
            InitializeComponent();
            InitialLoad();
        }

        private void InitialLoad()
        {
            var repo = new SecurityRepository();
            var rols = repo.GetRols();

            rols.Add(new Rol { RolID = -1, RolName = "Seleccionar" });
            rols.OrderBy(x => x.RolName);

            CbRol.DataSource = rols;
            CbRol.SelectedValue = -1;
            CbRolName.DataSource = rols;
            CbRolName.SelectedValue = -1;
        }
     

        private void CbStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (CbStatus.Checked == false) CbStatus.Text = "Inactivo";
            else CbStatus.Text = "Activo";
        }

        private void TxtUserId_Leave(object sender, EventArgs e)
        {
            FillUser(TxtUserId.Text.Trim());
        }


        private void FillUser(string userId)
        {
            var repo = new SecurityRepository();
            var user = repo.GetAppUser(userId);

            if (user != null)
            {
                TxtName.Text = user.Name;
                CbStatus.Checked = user.Status;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            if (ValidateFields())
            {
                var user = new AppUser()
                {
                    AppUserID = TxtUserId.Text.Trim(),
                    Name = TxtName.Text,
                    Password = TxtPwd.Text,
                    Status = CbStatus.Checked,
                    RolID = int.Parse(CbRol.SelectedValue.ToString())
                };

                var repo = new SecurityRepository();
                var result = repo.EditUser(user);

                if (result == true) MessageBox.Show(Constants.MSG_UpdateRecord);

                CleanForm();
            }
        }


        private void CleanForm()
        {
            TxtUserId.Text = string.Empty;
            TxtName.Text = string.Empty;
            TxtPwd.Text = string.Empty;
            CbStatus.Checked = true;
            CbRol.SelectedValue = -1;
        }

        private bool ValidateFields()
        {
            var flag = true;

            if (string.IsNullOrEmpty(TxtUserId.Text)) flag = false;
            if (string.IsNullOrEmpty(TxtName.Text)) flag = false;
            if (string.IsNullOrEmpty(TxtPwd.Text)) flag = false;
            if (CbRol.SelectedValue.ToString() == "-1") flag = false;

            return flag;
        }

        private void CbRolName_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CbRolName.SelectedValue.ToString() != "-1")
            {
                var repo = new SecurityRepository();
                var data = repo.GetRolsById(int.Parse(CbRolName.SelectedValue.ToString()));

                DgvData.AutoGenerateColumns = false;
                DgvData.DataSource = data;
            }            
        }

        private void CbRol_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CbRol.SelectedValue.ToString() != "-1")
            { }
        }
    }
}
