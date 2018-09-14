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
    public partial class FrmConfiguration : Form
    {
        public FrmConfiguration()
        {
            InitializeComponent();
            InitialLoad();
        }

        private void InitialLoad()
        {
            var repo = new ConfigurationRepository();
            DgvData.DataSource = repo.GetConfigData();
            DgvData.AutoGenerateColumns = false;

        }

        private void DgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DgvData.CurrentRow;
            int output;
            if (row.Cells[0].Value.ToString() != "")
            {
                bool flag = int.TryParse(row.Cells[0].Value.ToString(), out output);
                if (flag)
                {
                    var repo = new ConfigurationRepository();
                    var data = repo.GetConfigDataByID(int.Parse(row.Cells[0].Value.ToString()));
                    LblConfigurationID.Text = data.ConfigurationID.ToString();
                    TxtConfigName.Text = data.ConfigurationName;
                    TxtConfigValue.Text = data.ConfigurationValue;
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var repo = new ConfigurationRepository();

            var data = new Configuration()
            {
                ConfigurationID = int.Parse(LblConfigurationID.Text),
                ConfigurationName = TxtConfigName.Text,
                ConfigurationValue = TxtConfigValue.Text
            };

            var result = repo.SaveConfiguration(data);

            if (result != null) MessageBox.Show(Constants.MSG_UpdateRecord);

            ClearForm();

            InitialLoad();
        }

        public void ClearForm()
        {
            LblConfigurationID.Text = string.Empty;
            TxtConfigName.Text = string.Empty;
            TxtConfigValue.Text = string.Empty;
        }
    }
}
