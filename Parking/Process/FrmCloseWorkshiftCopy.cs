using Parking.Models;
using Parking.Repositories;
using Parking.Utilities;
using System.Windows.Forms;
using System;

namespace Parking.Process
{
    public partial class FrmCloseWorkshiftCopy : Form
    {
        public FrmCloseWorkshiftCopy()
        {
            InitializeComponent();
            InitialLoad();
        }

        private void InitialLoad()
        {
            var repo = new ReportRepository();
            var result = repo.GetCloseWorkShiftDates(Globals.appUserID);

            DgvData.AutoGenerateColumns = false;
            DgvData.DataSource = result;
        }

        private void DgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = DgvData.CurrentRow;

            DateTime data = DateTime.Parse(row.Cells[1].Value.ToString());
            int userID = int.Parse(row.Cells[3].Value.ToString());

            var repo = new ReportRepository();
            var repoReceipts = new Receipts();
            var eData = repo.GetCloseWorkShiftByUserDate(userID,  data);
            var path = repoReceipts.CloseWorkShift(eData);
            var repoPrint = new PrintReceipts();
            repoPrint.PrintPDFs(path);
        }
    }
}
