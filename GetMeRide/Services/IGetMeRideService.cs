using GetMeRide.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetMeRide.Services
{
   public  interface IGetMeRideService
    {
        IEnumerable<CarDetails> GetAllCabsDetails();
        Task<DriverDetails> GetDriverDetails(int cabId);

        Location GetBusLocation(int busId);


    }
}
