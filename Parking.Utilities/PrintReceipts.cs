using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;


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
                proc.StartInfo.Verb = "print";

                //Define location of adobe reader/command line
                //switches to launch adobe in "print" mode
                proc.StartInfo.FileName =
                  @"C:\Program Files (x86)\Adobe\Acrobat Reader DC\Reader\AcroRd32.exe";
                proc.StartInfo.Arguments = String.Format(@"/p /h {0}", pdfFileName);
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.CreateNoWindow = true;

                proc.Start();
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                if (proc.HasExited == false)
                {
                    //proc.WaitForExit(10000);
                    proc.WaitForExit(7000);
                }

                proc.EnableRaisingEvents = true;

                proc.Close();
                KillAdobe("AcroRd32");
                File.Delete(pdfFileName);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private static bool KillAdobe(string name)
        {
            foreach (Process clsProcess in Process.GetProcesses().Where(
                         clsProcess => clsProcess.ProcessName.StartsWith(name)))
            {
                clsProcess.Kill();
                return true;
            }
            return false;
        }

    }
}
