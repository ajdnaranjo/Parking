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
        public string EntryReceipt(string plate, DateTime entryDate)
        {

            var repo = new ConfigurationRepository();
            var config = repo.GetConfiguration();

            Document doc = new Document(new Rectangle(130f, 880f), 0, 0, 0, 0);
           
            var output = new FileStream(@"C:\Parking\Receipts\EntryReceipt.pdf", FileMode.Create);
            var writer = PdfWriter.GetInstance(doc, output);
        
            doc.Open();

            doc.Add(new Paragraph(config.Name, FontFactory.GetFont("helvetica", 8, Font.BOLD)));
            doc.Add(new Paragraph("Nit: " + config.Nit,FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph("Dir: " + config.Address, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph("Tel: " + config.Telephone, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph("Horario: " + config.Schedule, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph(config.Regime, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph("N. Recibo: 1 " , FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph("Placa: " + plate, FontFactory.GetFont("helvetica", 14, Font.BOLD)));
            doc.Add(new Paragraph("Entra: " + entryDate, FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph("Sale: ", FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph("Atendió: Juan Naranjo", FontFactory.GetFont("helvetica", 8)));
            doc.Add(new Paragraph(config.FootPage, FontFactory.GetFont("helvetica", 7)));

            doc.Close();

            return output.Name;
        }

        public void ExitReceipt()
        {

            Document doc = new Document(PageSize.A7);
            var output = new FileStream(@"C:\Users\junaranjo\Desktop\Parking\Parking\Parking\bin\Debug\Receipts\ExitReceipt.pdf", FileMode.Create);
            var writer = PdfWriter.GetInstance(doc, output);

            doc.Open();


            doc.Add(new Paragraph("Nit: "));
            doc.Add(new Paragraph("Barranquilla con las carnes peinadas"));
            doc.Add(new Paragraph("\n"));
            doc.Add(new Paragraph("Placa: "));
            doc.Add(new Paragraph("\n"));
            doc.Add(new Paragraph("LQE45B"));
            doc.Add(new Paragraph("Hora ingreso: "));

            doc.Close();

        }


        public void MonthlyPaymentReceipt()
        {

            Document doc = new Document(PageSize.A7);
            var output = new FileStream(@"C:\Users\junaranjo\Desktop\Parking\Parking\Parking\bin\Debug\Receipts\ExitReceipt.pdf", FileMode.Create);
            var writer = PdfWriter.GetInstance(doc, output);

            doc.Open();


            doc.Add(new Paragraph("Nit: "));
            doc.Add(new Paragraph("Barranquilla con las carnes peinadas"));
            doc.Add(new Paragraph("\n"));
            doc.Add(new Paragraph("Placa: "));
            doc.Add(new Paragraph("\n"));
            doc.Add(new Paragraph("LQE45B"));
            doc.Add(new Paragraph("Hora ingreso: "));

            doc.Close();

        }
    }
}
