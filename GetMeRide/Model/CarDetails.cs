using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GetMeRide.Model
{
    public class CarDetails
    {
        public int CarId { get; set; }
        public string ModelName { get; set; }
        public string Brand { get; set; }
        public string Colour { get; set; }
        public string Id { get; set; }
        public int NoOfPassenger { get; set; }
        public string Amount { get; set; }
        public string FuelType { get; set; }
        public DateTime CreatedOn { get; set; }
        public int UserId { get; set; }
         public int ETA { get; set; }
    }
}
