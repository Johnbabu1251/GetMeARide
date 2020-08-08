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
        public async Task<DriverDetails> GetDriverDetails(int cabId)
        {
            var details = wait _busDepoRepository.GetDriverDetails(cabID);
            DriverDetails driverDetails =  MapDriverDetails(details);

            return driverDetails;
        }

        private DriverDetails MapDriverDetails(DataTable details)
        {
            return details.AsEnumerable().Select(resource => new DriverDetails
            {
                DriverName = resource.Field<string>(Constants.Parameters.DRIVER_NAME),
                ContactNumber = resource.Field<long>(Constants.Parameters.CONTACT_NUMBER),
                Gender = resource.Field<string>(Constants.Parameters.GENDER),
                CabNumber = resource.Field<string>(Constants.Parameters.CAB_NUMBER),
                DriverLicense = resource.Field<string>(Constants.Parameters.DRIVER_LICENSE),
                Position = resource.Field<string>(Constants.Parameters.POSITION),
                ArrivalTime = resource.Field<DateTime>(Constants.Parameters.ARRIVAL_TIME)
            }).FirstOrDefault();
        }
        private static class Constants
        {
            public static class Parameters
            {
                public const string DRIVER_NAME = "DriverName";
                public const string CONTACT_NUMBER = "ContactNumber";
                public const string GENDER = "Gender";
                public const string DRIVER_LICENSE = "DriverLicense";
                public const string CAB_NUMBER = "CabNumber";
                public const string POSITION = "Position";
                public const DateTime ARRIVAL_TIME = "ArrivalTime";
            }
        }
    }
}
