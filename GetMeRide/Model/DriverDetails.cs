using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetMeRide.Model
{
    public class DriverDetails
    {
        public string DriverName { get; set; }
        public long ContactNumber { get; set; }
        public string Gender { get; set; }
        public string CabNumber { get; set; }
        public string DriverLicense { get; set; }
        public string Position { get; set; }
        public DateTime ArrivalTime { get; set; }
    }
}
