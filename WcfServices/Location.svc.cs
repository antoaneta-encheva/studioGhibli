using ApplicationService.DTOs;
using ApplicationService.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Location" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Location.svc or Location.svc.cs at the Solution Explorer and start debugging.
    public class Location : ILocation
    {
        #region Fields
        private LocationManagementService service = new LocationManagementService();
        #endregion

        public List<LocationDTO> GetLocations()
        {
            return service.Get();
        }
        public LocationDTO GetLocationByID(int id)
        {
            return service.GetLocationById(id);
        }
        public string PostLocation(LocationDTO locationDto)
        {
            if (!service.Save(locationDto))
                return "Location is not inserted";

            return "Location is inserted";
        }

        public string PutLocation(LocationDTO locationDto)
        {
            throw new NotImplementedException();
        }

        public string DeleteLocation(int id)
        {
            if (!service.Delete(id))
                return "Location is not deleted";

            return "Location is deleted";
        }

        public string Message()
        {
            return "My first wcf service";
        }


    }
}
