using System;
using System.Diagnostics;
using System.Linq;
using System.IO;
using System.Configuration;

namespace Parking.Utilities
{
    public class PrintReceipts
    {

        public  Boolean PrintPDFs(string pdfFileName)
        {
            try
            {
                Process proc = new Process();
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                proc.StartInfo.Verb = "PrintTo";

                //Define location of adobe reader/command line
                //switches to launch adobe in "print" mode
                proc.StartInfo.FileName = ConfigurationManager.AppSettings["AdobePath"];
               // @"C:\Program Files (x86)\Adobe\Acrobat Reader DC\Reader\AcroRd32.exe";
                proc.StartInfo.Arguments = String.Format(@"/p /h {0}", pdfFileName);
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.CreateNoWindow = true;

                proc.Start();
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                if (proc.HasExited == false)
                {                    
                    proc.WaitForExit(int.Parse(ConfigurationManager.AppSettings["WaitForExit"]));
                }

                proc.EnableRaisingEvents = true;

                proc.Close();
                var result = KillAdobe("AcroRd32");
                ParkingLogger.Information("resultado kill adobe: " + result.ToString());
                if (result == true)
                    File.Delete(pdfFileName);
                else
                {
                    throw new Exception("El proceso no se pudo detener.");
                }

                return true;
            }
            catch (Exception ex)
            {
                ParkingLogger.Error(ex.Message, ex);
                return false;
            }
        }

        private static bool KillAdobe(string name)
        {
            try
            {
                foreach (Process clsProcess in Process.GetProcesses().Where(
                             clsProcess => clsProcess.ProcessName.StartsWith(name)))
                {
                    clsProcess.Kill();                    
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
