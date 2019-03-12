using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Models
{
    [Serializable]
    public class RegistryDto
    {
       public string  RegistryID { get; set; }     
        public string Plate { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime? ExitDate { get; set; }
        public int? Days { get; set; }
        public int? Hours { get; set; }
        public int? Minutes { get; set; }
        public decimal? TotalPayment { get; set; }
        public decimal? Payment { get; set; }
        public decimal? Refund { get; set; }
        public int Locker { get; set; }
        public bool DayPayment { get; set; }
        public string IsInsite { get; set; }
    }
}
