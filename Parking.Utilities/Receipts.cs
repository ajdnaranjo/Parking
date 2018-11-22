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
            var repoRegistry = new RegistryRepository();
            var secureRepo = new SecurityRepository();
            
            var entry = repoRegistry.GetEntryRegistryByPlate(plate);
            var appUserData = secureRepo.GetAppUserByID(appUserID);

            var footItems = Globals.ConfigGlobal.FootItems.Split('*');

            Document doc = new Document(new Rectangle(130f, 880f), 0, 0, 0, 0);
           
            var output = new FileStream(@"C:\Parking\Receipts\EntryReceipt" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".pdf", FileMode.Create);
            var writer = PdfWriter.GetInstance(doc, output);
        
            doc.Open();

            Font font = new Font(FontFactory.GetFont("Helvetica", 8, Font.NORMAL));

            doc.Add(new Paragraph(Globals.ConfigGlobal.Name, FontFactory.GetFont("helvetica", 8, Font.BOLD)));
            doc.Add(new Paragraph("Nit: " + Globals.ConfigGlobal.Nit,font));
            doc.Add(new Paragraph("Dir: " + Globals.ConfigGlobal.Address,font));
            doc.Add(new Paragraph("Tel: " + Globals.ConfigGlobal.Telephone, font));
            doc.Add(new Paragraph("Horario: " + Globals.ConfigGlobal.Schedule, font));
            doc.Add(new Paragraph(Globals.ConfigGlobal.Regime, font));
            doc.Add(new Paragraph("N. Factura: " + Globals.ConfigGlobal.ReceiptLetter + entry.RegistryID, font));
            doc.Add(new Paragraph("Placa: " + plate, FontFactory.GetFont("helvetica", 14, Font.BOLD)));
            doc.Add(new Paragraph("Entra: " + entry.EntryDate, font));
            doc.Add(new Paragraph("Locker: " + entry.Locker, font));
            if (entry.DayPayment == true) doc.Add(new Paragraph("Pagó día!", font));
            doc.Add(new Paragraph("Le Atendió: " + appUserData.Name, font));         
         
            List listItems = new List(footItems.Length);

            font = new Font(FontFactory.GetFont("Helvetica", 7, Font.BOLD));

            doc.Add(new Paragraph(Globals.ConfigGlobal.FootTitle, font));

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
            var repoRegistry = new RegistryRepository();
            var secureRepo = new SecurityRepository();
         
            var exit = repoRegistry.GetExitRegistryByPlate(plate);
            var appUserData = secureRepo.GetAppUserByID(appUserID);


            Document doc = new Document(new Rectangle(130f, 880f), 0, 0, 0, 0);
            var output = new FileStream(@"C:\Parking\Receipts\ExitReceipt" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".pdf", FileMode.Create);
            var writer = PdfWriter.GetInstance(doc, output);

            doc.Open();

            decimal TotalPayment = (decimal)exit.TotalPayment;
            decimal Refund = (decimal)exit.Refund;

            Font font = new Font(FontFactory.GetFont("Helvetica", 8, Font.NORMAL));

            doc.Add(new Paragraph(Globals.ConfigGlobal.Name, FontFactory.GetFont("helvetica", 8, Font.BOLD)));
            doc.Add(new Paragraph("Nit: " + Globals.ConfigGlobal.Nit, font));
            doc.Add(new Paragraph("Dir: " + Globals.ConfigGlobal.Address, font));
            doc.Add(new Paragraph("Tel: " + Globals.ConfigGlobal.Telephone, font));
            doc.Add(new Paragraph("Horario: " + Globals.ConfigGlobal.Schedule, font));
            doc.Add(new Paragraph(Globals.ConfigGlobal.Regime, font));
            doc.Add(new Paragraph("N. Factura: " + Globals.ConfigGlobal.ReceiptLetter + exit.RegistryID, font));
            doc.Add(new Paragraph("Placa: " + plate, font));
            doc.Add(new Paragraph("Entra: " + exit.EntryDate, font));
            doc.Add(new Paragraph("Sale: " + exit.ExitDate, font));
            doc.Add(new Paragraph("Días: " + exit.Days + " Horas: " + exit.Hours + " Minutos: " + exit.Minutes, FontFactory.GetFont("helvetica", 8)));         
            doc.Add(new Paragraph("Total: " + TotalPayment.ToString(), FontFactory.GetFont("helvetica", 14, Font.BOLD)));
            doc.Add(new Paragraph("Pago con: " + exit.Payment, font));
            doc.Add(new Paragraph("Devuelta: " + Refund.ToString("N0"), font));
            if (exit.DayPayment == true) doc.Add(new Paragraph("Pagó día!", font));
            doc.Add(new Paragraph("Le Atendió: " + appUserData.Name, font));            

            doc.Close();

            return output.Name;
        }

        public string MonthlyPaymentReceipt(string monthlyPaymentID, int appUserID)
        {            
            var dataRepo = new RegistryRepository();
            var secureRepo = new SecurityRepository();
            
            var data = dataRepo.GetMonthlyPaymentByID(monthlyPaymentID);
            var appUserData = secureRepo.GetAppUserByID(appUserID);

            var footItems = Globals.ConfigGlobal.FootItems.Split('*');


            Document doc = new Document(new Rectangle(130f, 880f), 0, 0, 0, 0);
            var output = new FileStream(@"C:\Parking\Receipts\MonthlyReceipt" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".pdf", FileMode.Create);
            var writer = PdfWriter.GetInstance(doc, output);

            doc.Open();

            Font font = new Font(FontFactory.GetFont("Helvetica", 8, Font.NORMAL));

            doc.Add(new Paragraph(Globals.ConfigGlobal.Name, FontFactory.GetFont("helvetica", 8, Font.BOLD)));
            doc.Add(new Paragraph("Nit: " + Globals.ConfigGlobal.Nit, font));
            doc.Add(new Paragraph("Dir: " + Globals.ConfigGlobal.Address, font));
            doc.Add(new Paragraph("Tel: " + Globals.ConfigGlobal.Telephone, font));
            doc.Add(new Paragraph("Horario: " + Globals.ConfigGlobal.Schedule, font));
            doc.Add(new Paragraph(Globals.ConfigGlobal.Regime, font));
            doc.Add(new Paragraph("N. Factura: " + Globals.ConfigGlobal.ReceiptLetter + data.MonthlyPaymentID, font));
            doc.Add(new Paragraph("Placa: " + data.Plate, FontFactory.GetFont("helvetica", 14, Font.BOLD)));
            doc.Add(new Paragraph("Total: " + data.TotalPayment.ToString("N0"), FontFactory.GetFont("helvetica", 14, Font.BOLD)));
            doc.Add(new Paragraph("Pago con: " + data.PaidValue.ToString("N0"), font));
            doc.Add(new Paragraph("Devuelta: " + data.Refund.ToString("N0"), font));
            doc.Add(new Paragraph("Valido hasta: " + data.ExpirationDate, font));            
            doc.Add(new Paragraph("Le Atendió: " + appUserData.Name, font));

            List listItems = new List(footItems.Length);

            font = new Font(FontFactory.GetFont("Helvetica", 7, Font.BOLD));

            doc.Add(new Paragraph(Globals.ConfigGlobal.FootTitle, font));

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
            
            Document doc = new Document(new Rectangle(130f, 880f), 0, 0, 0, 0);
            var output = new FileStream(@"C:\Parking\Receipts\CloseWorkShift" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".pdf", FileMode.Create);
            var writer = PdfWriter.GetInstance(doc, output);

            doc.Open();

            Font font = new Font(FontFactory.GetFont("Helvetica", 8, Font.NORMAL));

            doc.Add(new Paragraph(Globals.ConfigGlobal.Name, FontFactory.GetFont("helvetica", 8, Font.BOLD)));
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
            var dataRepo = new RegistryRepository();
            var secureRepo = new SecurityRepository();
            
            var data = dataRepo.GetMonthlyPaymentByID(monthlyPaymentID);
            var appUserData = secureRepo.GetAppUserByID(appUserID);         

            Document doc = new Document(new Rectangle(130f, 880f), 0, 0, 0, 0);
            var output = new FileStream(@"C:\Parking\Receipts\MonthlyExpirationReceipt" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".pdf", FileMode.Create);
            var writer = PdfWriter.GetInstance(doc, output);

            doc.Open();

            Font font = new Font(FontFactory.GetFont("Helvetica", 8, Font.NORMAL));

            doc.Add(new Paragraph(Globals.ConfigGlobal.Name, FontFactory.GetFont("helvetica", 8, Font.BOLD)));
            doc.Add(new Paragraph("Nit: " + Globals.ConfigGlobal.Nit, font));
            doc.Add(new Paragraph("Dir: " + Globals.ConfigGlobal.Address, font));
            doc.Add(new Paragraph("Tel: " + Globals.ConfigGlobal.Telephone, font));
            doc.Add(new Paragraph("Horario: " + Globals.ConfigGlobal.Schedule, font));
            doc.Add(new Paragraph(Globals.ConfigGlobal.Regime, font));
            doc.Add(new Paragraph("N. Factura: " + Globals.ConfigGlobal.ReceiptLetter + data.MonthlyPaymentID, font));
            doc.Add(new Paragraph("Placa: " + data.Plate, FontFactory.GetFont("helvetica", 14, Font.BOLD)));           
            doc.Add(new Paragraph("Su mensualidad vence: " + data.ExpirationDate, FontFactory.GetFont("helvetica", 14, Font.BOLD)));            
            doc.Add(new Paragraph("Le Atendió: " + appUserData.Name, font));

           
            doc.Close();

            return output.Name;
        }


        public string PendingToExitReceipt()
        {            
            var dataRepo = new ReportRepository();
                       
            var data = dataRepo.GetPendingToExit();            

            Document doc = new Document(new Rectangle(130f, 880f), 0, 0, 0, 0);
            var output = new FileStream(@"C:\Parking\Receipts\PendingToExitReceipt" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".pdf", FileMode.Create);
            var writer = PdfWriter.GetInstance(doc, output);

            doc.Open();

            Font font = new Font(FontFactory.GetFont("Helvetica", 8, Font.NORMAL));

            doc.Add(new Paragraph(Globals.ConfigGlobal.Name, FontFactory.GetFont("Helvetica", 8, Font.NORMAL)));
            doc.Add(new Paragraph("\n"));
            doc.Add(new Paragraph("Motos en sitio.", font));
            doc.Add(new Paragraph("\n"));

            var plates = string.Empty;

            foreach (var item in data)
            {                
                plates = plates + " " + " - " + " " + item.Plate ;                
            }

            doc.Add(new Paragraph(plates, font));

            doc.Close();

            return output.Name;
        }

    }
}

