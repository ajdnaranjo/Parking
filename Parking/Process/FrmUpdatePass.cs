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
    public partial class FrmUpdatePass : Form
    {
        public FrmUpdatePass()
        {
            InitializeComponent();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidFields()) UpdatePass();
        }

        private bool ValidFields()
        {
            var flag = true; ;

            if (string.IsNullOrEmpty(TxtPreviousPass.Text)) flag = false;
            if (string.IsNullOrEmpty(TxtNewPass1.Text)) flag = false;
            if (string.IsNullOrEmpty(txtNewPass2.Text)) flag = false;

            return flag;
        }


        private void UpdatePass()
        {
            var repo = new SecurityRepository();
            var user = repo.GetAppUserByID(Globals.appUserID);
            var result = repo.ValidUser(user.AppUserID, TxtPreviousPass.Text);
            if (!result)
            {
                MessageBox.Show("La contraseña actual no es correcta.");
            }
            else {
                if (TxtNewPass1.Text == txtNewPass2.Text)
                {
                    var r =  repo.UpdatePass(Globals.appUserID, TxtNewPass1.Text);

                    if (r) MessageBox.Show("La contraseña se actualizó correctamente.");
                    else MessageBox.Show("Fallo en la actualización, intente nuevamente.");
                }
                else {
                    MessageBox.Show("La nueva contraseña debe ser igual.");
                }
            }
        }
    }
}
