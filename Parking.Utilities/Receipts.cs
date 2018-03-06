using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Parking.Utilities
{
    public class Receipts
    {
        public void EntryReceipt()
        {

            Document doc = new Document(PageSize.A7);
            var output = new FileStream(@"C:\Users\junaranjo\Desktop\Parking\Parking\Parking\bin\Debug\Receipts\EntryReceipt.pdf", FileMode.Create);
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
