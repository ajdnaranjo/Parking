using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Models
{
    [Serializable]
    public class CloseWorkShiftDto
    {
        public int UserID { get; set; }
        public string AppUserID { get; set; }
        public string Name { get; set; }
        public int MonthlyPaymentCount { get; set; }
        public decimal MonthlyPaymentValue { get; set; }
        public int DailyRegistryCount { get; set; }
        public decimal DailyRegistryValue { get; set; }

    }
}
 