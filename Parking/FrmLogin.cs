using Parking.Repositories;
using System;
using System.Windows.Forms;

namespace Parking
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLoguin_Click(object sender, EventArgs e)
        {
            var repo = new SecurityRepository();
            var canLogin = repo.ValidUser(TxtUser.Text.Trim(), TxtPass.Text);

            if (canLogin)
            {
                this.Hide();
                var frm = new MDIContainer(TxtUser.Text.Trim());                
                frm.Show();
                
            }
            else MessageBox.Show("Datos de acceso incorrectos");
        }
    }
}
