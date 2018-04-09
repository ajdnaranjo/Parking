using iTextSharp.text;
using iTextSharp.text.pdf;
using Parking.Repositories;
using System;
using System.IO;

namespace Parking.Utilities
{
    public class Receipts
    {
        public string EntryReceipt(string plate, int appUserID)
        {

            var repo = new ConfigurationRepository();
            var repoRegistry = new RegistryRepository();
            var secureRepo = new SecurityRepository();

            var config = repo.GetConfiguration();
            var entry = repoRegistry.GetEntryRegistryByPlate(plate);
            var appUserData = secureRepo.GetAppUserByID(appUserID);

            Document doc = new Document(new Rectangle(130f, 880f), 0, 0, 0, 0);
           
            var output = new FileStream(@"C:\Parking\Receipts\EntryReceipt.pdf", FileMode.Create);
            var writer = PdfWriter.GetInstance(doc, output);
        
            doc.Open();

            doc.Add(new Paragraph(config.Name, FontFactory.GetFont("helvetica", 10, Font.BOLD)));
            doc.Add(new Paragraph("Nit: " + config.Nit,FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph("Dir: " + config.Address, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph("Tel: " + config.Telephone, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph("Horario: " + config.Schedule, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph(config.Regime, FontFactory.GetFont("helvetica", 8)));           
            doc.Add(new Paragraph("Placa: " + plate, FontFactory.GetFont("helvetica", 14, Font.BOLD)));
            doc.Add(new Paragraph("Entra: " + entry.EntryDate, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph("Sale: ", FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph("Le Atendió: " + appUserData.Name, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph(config.FootPage, FontFactory.GetFont("helvetica", 7)));

            doc.Close();

            return output.Name;
        }

        public string  ExitReceipt(string plate, int appUserID )
        {
            var repo = new ConfigurationRepository();
            var repoRegistry = new RegistryRepository();
            var secureRepo = new SecurityRepository();

            var config = repo.GetConfiguration();
            var exit = repoRegistry.GetExitRegistryByPlate(plate);
            var appUserData = secureRepo.GetAppUserByID(appUserID);


            Document doc = new Document(new Rectangle(130f, 880f), 0, 0, 0, 0);
            var output = new FileStream(@"C:\Parking\Receipts\EntryReceipt" + DateTime.Now.ToShortTimeString() + ".pdf", FileMode.Create);
            var writer = PdfWriter.GetInstance(doc, output);

            doc.Open();

            doc.Add(new Paragraph(config.Name, FontFactory.GetFont("helvetica", 10, Font.BOLD)));
            doc.Add(new Paragraph("Nit: " + config.Nit, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph("Dir: " + config.Address, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph("Tel: " + config.Telephone, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph("Horario: " + config.Schedule, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph(config.Regime, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph("N. Recibo: " + exit.RegistryID, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph("Placa: " + plate, FontFactory.GetFont("helvetica", 14, Font.BOLD)));
            doc.Add(new Paragraph("Entra: " + exit.EntryDate, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph("Sale: " + exit.ExitDate, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph("Horas: " + exit.Hours, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph("Minutos: " + exit.Minutes, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph("Total: " + exit.TotalPayment, FontFactory.GetFont("helvetica", 14, Font.BOLD)));
            doc.Add(new Paragraph("Devuelta: " + exit.Refund, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph("Le Atendió: " + appUserData.Name, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph(config.FootPage, FontFactory.GetFont("helvetica", 7)));

            doc.Close();

            return output.Name;
        }


        public void MonthlyPaymentReceipt(string monthlyPaymentID, int appUserID)
        {
            var repo = new ConfigurationRepository();
            var dataRepo = new RegistryRepository();
            var secureRepo = new SecurityRepository();

            var config = repo.GetConfiguration();
            var data = dataRepo.GetMonthlyPaymentByID(monthlyPaymentID);
            var appUserData = secureRepo.GetAppUserByID(appUserID);


            Document doc = new Document(new Rectangle(130f, 880f), 0, 0, 0, 0);
            var output = new FileStream(@"C:\Parking\Receipts\MonthlyReceipt" + DateTime.Now.ToShortTimeString() + ".pdf", FileMode.Create);
            var writer = PdfWriter.GetInstance(doc, output);

            doc.Open();

            doc.Add(new Paragraph(config.Name, FontFactory.GetFont("helvetica", 10, Font.BOLD)));
            doc.Add(new Paragraph("Nit: " + config.Nit, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph("Dir: " + config.Address, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph("Tel: " + config.Telephone, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph("Horario: " + config.Schedule, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph(config.Regime, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph("N. Recibo: " + data.ReceiptID, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph("Placa: " + data.Plate, FontFactory.GetFont("helvetica", 14, Font.BOLD)));
            doc.Add(new Paragraph("Total: " + data.TotalPayment, FontFactory.GetFont("helvetica", 14, Font.BOLD)));
            doc.Add(new Paragraph("Devuelta: " + data.Refund, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph("Valido hasta: " + data.ExpirationDate, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph("N. Recibo: " + data.ReceiptID, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph("Le Atendió: " + appUserData.Name, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph(config.FootPage, FontFactory.GetFont("helvetica", 7)));

            doc.Close();

        }
    }
}
