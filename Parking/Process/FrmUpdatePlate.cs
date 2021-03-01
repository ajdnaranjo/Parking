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
using Parking.Utilities;
using System.Text.RegularExpressions;

namespace Parking.Process
{
    public partial class FrmUpdatePlate : Form
    {
        public FrmUpdatePlate()
        {
            InitializeComponent();
        }

        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var repo = new UserRepository();
            var repo2 = new MonthlyRepository();

            var client = new Client()
            {
                Plate = txtActualPlate.Text.Trim()
            };

            string newPlate = txtNewPlate.Text.Trim();
            try
            {
                var user = repo.DuplicateClient(client, newPlate);
                var update = repo2.UpdateMonthlyPaymentsPlate(client.Plate, newPlate);

                if (update)
                {
                    MessageBox.Show("La placa se actualizó correctamente.");
                    txtNewPlate.Text = string.Empty;
                    txtActualPlate.Text = string.Empty;
                }
            }
            catch (Exception ex){
                MessageBox.Show("Error al intentar actualizar la placa.");
                ParkingLogger.Error("FrmUpdatePlate", ex);
            }
        }

        private void txtActualPlate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtNewPlate_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtActualPlate_TextChanged(object sender, EventArgs e)
        {
            txtActualPlate.Text = ValidatePlate(txtActualPlate.Text.Trim());
            txtActualPlate.Select(txtActualPlate.Text.Length, 0);
        }

        private void txtNewPlate_TextChanged(object sender, EventArgs e)
        {
            txtNewPlate.Text = ValidatePlate(txtNewPlate.Text.Trim());
            txtNewPlate.Select(txtNewPlate.Text.Length, 0);
        }
    }
}
