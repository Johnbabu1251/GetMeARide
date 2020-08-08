using GetMeRide.Model;
using GetMeRide.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetMeRide.Services
{
    public class GetMeRideService : IGetMeRideService
    {
        private readonly IGetMeRideRepository _busDepoRepository;
        public GetMeRideService(IGetMeRideRepository busDepoRepository)
        {
            _busDepoRepository = busDepoRepository;
        }
        public IEnumerable<CarDetails> GetAllCabsDetails()
        {
            return _busDepoRepository.GetAllCabsDetails();
        }

        public Location GetBusLocation(int busId)
        {
            return _busDepoRepository.GetBusLocation(busId);
        }
    }
}
