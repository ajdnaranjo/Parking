namespace Parking
{
    partial class ctrlPlate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtPlate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtPlate
            // 
            this.TxtPlate.Location = new System.Drawing.Point(0, 0);
            this.TxtPlate.Name = "TxtPlate";
            this.TxtPlate.Size = new System.Drawing.Size(100, 20);
            this.TxtPlate.TabIndex = 0;
            this.TxtPlate.TextChanged += new System.EventHandler(this.TxtPlate_TextChanged);
            // 
            // ctrlPlate
            // 
            this.Name = "ctrlPlate";
            this.Size = new System.Drawing.Size(186, 31);
            this.Load += new System.EventHandler(this.ctrlPlate_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPlate;
    }
}
