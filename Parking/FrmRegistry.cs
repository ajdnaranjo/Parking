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

namespace Parking
{
    public partial class FrmRegistry : Form
    {
        public FrmRegistry()
        {
            InitializeComponent();

        }

        private void tHour_Tick(object sender, EventArgs e)
        {
            lblHour.Text = DateTime.Now.Hour.ToString() + ":" +
                DateTime.Now.Minute.ToString() + ":" +
                DateTime.Now.Second.ToString() ;
        }
    
 

        private void txtPlate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                lblIngreso.Text = DateTime.Now.ToString();

                var repo = new RegistryRepository();

                var reg = new Registry()
                {
                    Plate = txtPlate.Text.Trim(),
                    EntryDate = DateTime.Now
                };

                repo.RegisterVehicle(reg);
            }
        }
    }
}
