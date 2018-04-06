using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Parking.Models;
using Parking.Repositories;

namespace Parking.Utilities
{
    public class Receipts
    {
        public string EntryReceipt(string plate)
        {

            var repo = new ConfigurationRepository();
            var repoRegistry = new RegistryRepository();
            var config = repo.GetConfiguration();
            var entry = repoRegistry.GetEntryRegistryByPlate(plate);

            Document doc = new Document(new Rectangle(130f, 880f), 0, 0, 0, 0);
           
            var output = new FileStream(@"C:\Parking\Receipts\EntryReceipt" + DateTime.Now + ".pdf", FileMode.Create);
            var writer = PdfWriter.GetInstance(doc, output);
        
            doc.Open();

            doc.Add(new Paragraph(config.Name, FontFactory.GetFont("helvetica", 8, Font.BOLD)));
            doc.Add(new Paragraph("Nit: " + config.Nit,FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph("Dir: " + config.Address, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph("Tel: " + config.Telephone, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph("Horario: " + config.Schedule, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph(config.Regime, FontFactory.GetFont("helvetica", 8)));           
            doc.Add(new Paragraph("Placa: " + plate, FontFactory.GetFont("helvetica", 14, Font.BOLD)));
            doc.Add(new Paragraph("Entra: " + entry.EntryDate, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph("Sale: ", FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph("Atendió: " , FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph(config.FootPage, FontFactory.GetFont("helvetica", 7)));

            doc.Close();

            return output.Name;
        }

        public string  ExitReceipt(string plate)
        {
            var repo = new ConfigurationRepository();
            var repoRegistry = new RegistryRepository();
            var config = repo.GetConfiguration();
            var exit = repoRegistry.GetExitRegistryByPlate(plate);

            Document doc = new Document(new Rectangle(130f, 880f), 0, 0, 0, 0);
            var output = new FileStream(@"C:\Parking\Receipts\EntryReceipt" + DateTime.Now + ".pdf", FileMode.Create);
            var writer = PdfWriter.GetInstance(doc, output);

            doc.Open();

            doc.Add(new Paragraph(config.Name, FontFactory.GetFont("helvetica", 8, Font.BOLD)));
            doc.Add(new Paragraph("Nit: " + config.Nit, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph("Dir: " + config.Address, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph("Tel: " + config.Telephone, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph("Horario: " + config.Schedule, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph(config.Regime, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph("N. Recibo: " + exit.RegistryID, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph("Placa: " + plate, FontFactory.GetFont("helvetica", 14, Font.BOLD)));
            doc.Add(new Paragraph("Entra: " + exit.EntryDate, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph("Sale: " + exit.ExitDate, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph("Atendió: Juan Naranjo", FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph(config.FootPage, FontFactory.GetFont("helvetica", 7)));

            doc.Close();

            return output.Name;
        }


        public void MonthlyPaymentReceipt()
        {
            var repo = new ConfigurationRepository();           
            var config = repo.GetConfiguration();
            
            Document doc = new Document(new Rectangle(130f, 880f), 0, 0, 0, 0);
            var output = new FileStream(@"C:\Parking\Receipts\MonthlyReceipt" + DateTime.Now + ".pdf", FileMode.Create);
            var writer = PdfWriter.GetInstance(doc, output);

            doc.Open();

            doc.Add(new Paragraph(config.Name, FontFactory.GetFont("helvetica", 8, Font.BOLD)));
            doc.Add(new Paragraph("Nit: " + config.Nit, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph("Dir: " + config.Address, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph("Tel: " + config.Telephone, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph("Horario: " + config.Schedule, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph(config.Regime, FontFactory.GetFont("helvetica", 8)));
            //doc.Add(new Paragraph("N. Recibo: " + exit.RegistryID, FontFactory.GetFont("helvetica", 8)));
            //doc.Add(new Paragraph("Placa: " + plate, FontFactory.GetFont("helvetica", 14, Font.BOLD)));          
            doc.Add(new Paragraph("Atendió: Juan Naranjo", FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph(config.FootPage, FontFactory.GetFont("helvetica", 7)));

            doc.Close();

        }
    }
}
