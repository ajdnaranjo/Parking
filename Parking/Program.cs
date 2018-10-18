using System;
using System.Windows.Forms;
using System.Configuration;


namespace Parking
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Configuration cm = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
          
            ConfigurationSection ms = cm.GetSection("connectionStrings");

            if (!ms.SectionInformation.IsProtected)

            {
                ms.SectionInformation.ProtectSection("RsaProtectedConfigurationProvider");

                ms.SectionInformation.ForceSave = true;

                cm.Save(ConfigurationSaveMode.Full);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MDIContainer());
            Application.Run(new FrmLogin());
        }
    }
}
