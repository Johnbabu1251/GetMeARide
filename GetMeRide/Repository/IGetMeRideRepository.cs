using GetMeRide.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetMeRide.Repository
{
    public interface IGetMeRideRepository
    {
        IEnumerable<CarDetails> GetAllCabsDetails();

        Location GetBusLocation(int busId);

    }
}
