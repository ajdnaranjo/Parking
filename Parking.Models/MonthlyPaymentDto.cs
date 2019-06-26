using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Models
{
    public class MonthlyPaymentDto
    {
        public string MonthlyPaymentID { get; set; }
        public string Document { get; set; }
        public int DocTypeId { get; set; }
        public string Name { get; set; }
        public string Celphone { get; set; }       
        public string Plate { get; set; }
        public decimal PaidValue { get; set; }
        public decimal TotalPayment { get; set; }
        public decimal Refund { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsWorkShiftClosed { get; set; }
        public string CellPhone  { get; set; }
        public string PaymentDescriptiion { get; set; }
        public int  PaymentMethodID { get; set; }
        public bool Status { get; set; }
        public int CreatedBy { get; set; }
    }
}
