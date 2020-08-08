using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetMeRide.Model
{
    public class BookingDetails
    {
        public int BookingId { get; set; }
        public string Name { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public string  S_Destination {get;set;}

        public string D_Destination { get; set; }

        public string EmailId { get; set; }

        public string ContactNo { get; set; }

        public string Amount { get; set; }

        public string UserId { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
