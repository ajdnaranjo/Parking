using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Models
{
    [Serializable]
    public class RolAccessDTO
    {
        public string AppUserID { get; set; }
        public int RolID { get; set; }
        public string RolName { get; set; }
        public int FormID { get; set; }
        public string FormName { get; set; }

    }
}
