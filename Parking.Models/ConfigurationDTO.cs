using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Models
{
    [Serializable]
    public class ConfigurationDTO
    {
        public string Name { get; set; }
        public string Nit { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Schedule { get; set; }
        public string Regime { get; set; }
        public string FootTitle { get; set; }
        public string DayHours { get; set; }
        public string StartNight { get; set; }
        public string FootItems { get; set; }
        public string StartDay { get; set; }
        public int Lockers { get; set; }
    }
}
