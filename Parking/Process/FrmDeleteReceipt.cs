using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Parking.Repositories;
using Parking.Utilities;
using Parking.Models;

namespace Parking.Process
{
    public partial class FrmDeleteReceipt : Form
    {
        public FrmDeleteReceipt()
        {
            InitializeComponent();
        }

        private void txtReceiptNumber_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtReceiptNumber.Text, "[^0-9]"))
            {
                MessageBox.Show("Sólo se deben ingresar números.");
                txtReceiptNumber.Text = txtReceiptNumber.Text.Remove(txtReceiptNumber.Text.Length - 1);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var repo = new RegistryRepository();

            var receipt = txtReceiptNumber.Text.Trim();

            try
            {
                if (MessageBox.Show(string.Format("Esta seguro que desea eliminar el recibo número {0}", receipt) , "Borrar recibo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    var result = repo.DeleteReceipt(receipt, Globals.appUserID);

                    if (result != null) MessageBox.Show(string.Format("El recibo número {0} fué borrado correctamente", receipt));
                    else MessageBox.Show(string.Format("El recibo número {0} no existe o ya fué eliminado.", receipt));

                    txtReceiptNumber.Text = string.Empty;
                }
            }
            catch(Exception ex)
            {
                ParkingLogger.Error("Delete receipt - ", ex);
            }
        }
    }
}
