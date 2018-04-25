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
using System.IO;
using System.Data.SqlClient;
using System.Configuration;


namespace Parking.Reports
{
    public partial class FrmMonthlyPayments : Form
    {
        public FrmMonthlyPayments()
        {
            InitializeComponent();
            InitialLoad();
        }

        public void InitialLoad()
        {
            var repo = new RegistryRepository();

            DgvReport.AutoGenerateColumns = false;
            DgvReport.DataSource = repo.GetActiveMonthlyPayments();
           
        }


        private void ExportDataGridViewExcel(DataGridView grd)
        {
            SaveFileDialog file = new SaveFileDialog();
            file.Filter = "Excel (*.xls)|*.xls";
            if (file.ShowDialog() == DialogResult.OK)
            {                
                Microsoft.Office.Interop.Excel.Application app;
                Microsoft.Office.Interop.Excel.Workbook books;
                Microsoft.Office.Interop.Excel.Worksheet sheets;
                app = new Microsoft.Office.Interop.Excel.Application();
                books = app.Workbooks.Add();

                sheets = (Microsoft.Office.Interop.Excel.Worksheet)books.Worksheets.get_Item(1);

                for (int i = 0; i < grd.ColumnCount; i++)
                {
                    sheets.Cells[1, i + 1] = grd.Columns[i].HeaderText;
                }
                
                for (int i = 0; i < grd.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < grd.Columns.Count; j++)
                    {
                        sheets.Cells[i + 2, j + 1] = grd.Rows[i].Cells[j].Value.ToString();
                    }
                }
                books.SaveAs(file.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                books.Close(true);
                app.Quit();
            }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            ExportDataGridViewExcel(DgvReport);
        }
    }
}
