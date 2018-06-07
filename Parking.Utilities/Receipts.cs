using iTextSharp.text;
using iTextSharp.text.pdf;
using Parking.Repositories;
using System.IO;
using System;
using Parking.Models;


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

            var footItems = config.FootItems.Split('*');

            Document doc = new Document(new Rectangle(130f, 880f), 0, 0, 0, 0);
           
            var output = new FileStream(@"C:\Parking\Receipts\EntryReceipt" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".pdf", FileMode.Create);
            var writer = PdfWriter.GetInstance(doc, output);
        
            doc.Open();

            Font font = new Font(FontFactory.GetFont("Helvetica", 8, Font.NORMAL));

            doc.Add(new Paragraph(config.Name, FontFactory.GetFont("helvetica", 8, Font.BOLD)));
            doc.Add(new Paragraph("Nit: " + config.Nit,font));
            doc.Add(new Paragraph("Dir: " + config.Address,font));
            doc.Add(new Paragraph("Tel: " + config.Telephone, font));
            doc.Add(new Paragraph("Horario: " + config.Schedule, font));
            doc.Add(new Paragraph(config.Regime, font));
            doc.Add(new Paragraph("N. Factura: " + entry.RegistryID, font));
            doc.Add(new Paragraph("Placa: " + plate, FontFactory.GetFont("helvetica", 14, Font.BOLD)));
            doc.Add(new Paragraph("Entra: " + entry.EntryDate, font));           
            doc.Add(new Paragraph("Le Atendió: " + appUserData.Name, font));         
         
            List listItems = new List(footItems.Length);

            font = new Font(FontFactory.GetFont("Helvetica", 7, Font.BOLD));

            doc.Add(new Paragraph(config.FootTitle, font));

            foreach (var item in footItems)
            {
                listItems.Add(new ListItem(item, font));
            }

            doc.Add(listItems);

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
            var output = new FileStream(@"C:\Parking\Receipts\ExitReceipt" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".pdf", FileMode.Create);
            var writer = PdfWriter.GetInstance(doc, output);

            doc.Open();

            decimal TotalPayment = (decimal)exit.TotalPayment;
            decimal Refund = (decimal)exit.Refund;

            Font font = new Font(FontFactory.GetFont("Helvetica", 8, Font.NORMAL));

            doc.Add(new Paragraph(config.Name, FontFactory.GetFont("helvetica", 8, Font.BOLD)));
            doc.Add(new Paragraph("Nit: " + config.Nit, font));
            doc.Add(new Paragraph("Dir: " + config.Address, font));
            doc.Add(new Paragraph("Tel: " + config.Telephone, font));
            doc.Add(new Paragraph("Horario: " + config.Schedule, font));
            doc.Add(new Paragraph(config.Regime, font));
            doc.Add(new Paragraph("N. Factura: " + exit.RegistryID, font));
            doc.Add(new Paragraph("Placa: " + plate, font));
            doc.Add(new Paragraph("Entra: " + exit.EntryDate, font));
            doc.Add(new Paragraph("Sale: " + exit.ExitDate, font));
            doc.Add(new Paragraph("Días: " + exit.Days + " Horas: " + exit.Hours + " Minutos: " + exit.Minutes, FontFactory.GetFont("helvetica", 8)));         
            doc.Add(new Paragraph("Total: " + TotalPayment.ToString(), FontFactory.GetFont("helvetica", 14, Font.BOLD)));
            doc.Add(new Paragraph("Pago con: " + exit.Payment, font));
            doc.Add(new Paragraph("Devuelta: " + Refund.ToString("N0"), font));
            doc.Add(new Paragraph("Le Atendió: " + appUserData.Name, font));            

            doc.Close();

            return output.Name;
        }

        public string MonthlyPaymentReceipt(string monthlyPaymentID, int appUserID)
        {
            var repo = new ConfigurationRepository();
            var dataRepo = new RegistryRepository();
            var secureRepo = new SecurityRepository();

            var config = repo.GetConfiguration();
            var data = dataRepo.GetMonthlyPaymentByID(monthlyPaymentID);
            var appUserData = secureRepo.GetAppUserByID(appUserID);

            var footItems = config.FootItems.Split('*');


            Document doc = new Document(new Rectangle(130f, 880f), 0, 0, 0, 0);
            var output = new FileStream(@"C:\Parking\Receipts\MonthlyReceipt" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".pdf", FileMode.Create);
            var writer = PdfWriter.GetInstance(doc, output);

            doc.Open();

            Font font = new Font(FontFactory.GetFont("Helvetica", 8, Font.NORMAL));

            doc.Add(new Paragraph(config.Name, FontFactory.GetFont("helvetica", 8, Font.BOLD)));
            doc.Add(new Paragraph("Nit: " + config.Nit, font));
            doc.Add(new Paragraph("Dir: " + config.Address, font));
            doc.Add(new Paragraph("Tel: " + config.Telephone, font));
            doc.Add(new Paragraph("Horario: " + config.Schedule, font));
            doc.Add(new Paragraph(config.Regime, font));
            doc.Add(new Paragraph("N. Factura: " + data.ReceiptID, font));
            doc.Add(new Paragraph("Placa: " + data.Plate, FontFactory.GetFont("helvetica", 14, Font.BOLD)));
            doc.Add(new Paragraph("Total: " + data.TotalPayment.ToString("N0"), FontFactory.GetFont("helvetica", 14, Font.BOLD)));
            doc.Add(new Paragraph("Devuelta: " + data.Refund.ToString("N0"), font));
            doc.Add(new Paragraph("Valido hasta: " + data.ExpirationDate, font));            
            doc.Add(new Paragraph("Le Atendió: " + appUserData.Name, font));

            List listItems = new List(footItems.Length);

            font = new Font(FontFactory.GetFont("Helvetica", 7, Font.BOLD));

            doc.Add(new Paragraph(config.FootTitle, font));

            foreach (var item in footItems)
            {
                listItems.Add(new ListItem(item, font));
            }

            doc.Add(listItems);

            doc.Close();

            return output.Name;
        }

        public string CloseWorkShift(CloseWorkShiftDto data)
        {
            var repo = new ConfigurationRepository();           

            var config = repo.GetConfiguration();

            //var rec = new Rectangle(130f, 880f);
            //rec.Border = Rectangle.BOX;
            //rec.BorderWidth = 0f;                       

            //Document doc = new Document(rec);

            Document doc = new Document(new Rectangle(130f, 880f), 0, 0, 0, 0);
            var output = new FileStream(@"C:\Parking\Receipts\CloseWorkShift" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".pdf", FileMode.Create);
            var writer = PdfWriter.GetInstance(doc, output);

            doc.Open();

            Font font = new Font(FontFactory.GetFont("Helvetica", 8, Font.NORMAL));

            doc.Add(new Paragraph(config.Name, FontFactory.GetFont("helvetica", 8, Font.BOLD)));
            doc.Add(new Paragraph("Cierra de turno", FontFactory.GetFont("helvetica", 8, Font.BOLD)));
            doc.Add(new Paragraph("Fecha: " + DateTime.Now, font ));
            doc.Add(new Paragraph("Nombre : " + data.Name, font));
            doc.Add(new Paragraph("\n"));

            font = new Font(FontFactory.GetFont("Helvetica", 7, Font.NORMAL));

            PdfPTable table = new PdfPTable(3);           
            table.AddCell(new PdfPCell(new Phrase("Tipo Ingreso", font)));
            table.AddCell(new PdfPCell(new Phrase("Cantidad", font)));
            table.AddCell(new PdfPCell(new Phrase("Valor Total", font)));
            table.AddCell(new PdfPCell(new Phrase("Mensualidad", font)));
            table.AddCell(new PdfPCell(new Phrase(data.MonthlyPaymentCount.ToString(), font)));
            table.AddCell(new PdfPCell(new Phrase(data.MonthlyPaymentValue.ToString("N0"), font)));
            table.AddCell(new PdfPCell(new Phrase("Ingreso diario", font)));
            table.AddCell(new PdfPCell(new Phrase(data.DailyRegistryCount.ToString(), font)));
            table.AddCell(new PdfPCell(new Phrase(data.DailyRegistryValue.ToString("N0"), font)));
            table.AddCell(new PdfPCell(new Phrase("Total", font)));
            table.AddCell(string.Empty);
            table.AddCell(new PdfPCell(new Phrase((data.MonthlyPaymentValue + data.DailyRegistryValue).ToString("N0"), font)));

            doc.Add(table);

            doc.Close();

            return output.Name;
        }

        public string MonthlyPaymentExpirationReceipt(string monthlyPaymentID, int appUserID)
        {
            var repo = new ConfigurationRepository();
            var dataRepo = new RegistryRepository();
            var secureRepo = new SecurityRepository();

            var config = repo.GetConfiguration();
            var data = dataRepo.GetMonthlyPaymentByID(monthlyPaymentID);
            var appUserData = secureRepo.GetAppUserByID(appUserID);         


            Document doc = new Document(new Rectangle(130f, 880f), 0, 0, 0, 0);
            var output = new FileStream(@"C:\Parking\Receipts\MonthlyExpirationReceipt" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".pdf", FileMode.Create);
            var writer = PdfWriter.GetInstance(doc, output);

            doc.Open();

            Font font = new Font(FontFactory.GetFont("Helvetica", 8, Font.NORMAL));

            doc.Add(new Paragraph(config.Name, FontFactory.GetFont("helvetica", 8, Font.BOLD)));
            doc.Add(new Paragraph("Nit: " + config.Nit, font));
            doc.Add(new Paragraph("Dir: " + config.Address, font));
            doc.Add(new Paragraph("Tel: " + config.Telephone, font));
            doc.Add(new Paragraph("Horario: " + config.Schedule, font));
            doc.Add(new Paragraph(config.Regime, font));
            doc.Add(new Paragraph("N. Factura: " + data.ReceiptID, font));
            doc.Add(new Paragraph("Placa: " + data.Plate, FontFactory.GetFont("helvetica", 14, Font.BOLD)));           
            doc.Add(new Paragraph("Su mensualidad vence: " + data.ExpirationDate, FontFactory.GetFont("helvetica", 14, Font.BOLD)));            
            doc.Add(new Paragraph("Le Atendió: " + appUserData.Name, font));

           
            doc.Close();

            return output.Name;
        }

    }
}

