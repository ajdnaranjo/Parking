using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Parking
{
    public partial class ctrlPlate : UserControl
    {
        public ctrlPlate()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
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

        private void TxtPlate_TextChanged(object sender, EventArgs e)
        {
            TxtPlate.Text = ValidatePlate(TxtPlate.Text.Trim());
            TxtPlate.Select(TxtPlate.Text.Length, 0);

        }

        private void ctrlPlate_Load(object sender, EventArgs e)
        {

        }
    }
}
