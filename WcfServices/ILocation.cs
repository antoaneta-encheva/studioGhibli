using ApplicationService.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ILocation" in both code and config file together.
    [ServiceContract]
    public interface ILocation
    {
        [OperationContract]
        List<LocationDTO> GetLocations();

        [OperationContract]
        LocationDTO GetLocationByID(int id);

        [OperationContract]
        string PostLocation(LocationDTO locationDto);

        [OperationContract]
        string PutLocation(LocationDTO locationDto);

        [OperationContract]
        string DeleteLocation(int id);

        [OperationContract]
        string Message();
    }
}
