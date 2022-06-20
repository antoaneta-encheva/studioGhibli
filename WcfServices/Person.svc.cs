using ApplicationService.DTOs;
using ApplicationService.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Person : IPerson
    {
        #region Fields
        private PersonManagementService service = new PersonManagementService();
        #endregion

        public List<PersonDTO> GetPersons()
        {
            return service.Get();
        }

        public string PostPerson(PersonDTO personDto)
        {
            if (!service.Save(personDto))
                return "Person is not inserted";

            return "Person is inserted";
        }

        public string PutPerson(PersonDTO personDto)
        {
            throw new NotImplementedException();
        }

        public string DeletePerson(int id)
        {
            if (!service.Delete(id))
                return "Person is not deleted";

            return "Person is deleted";
        }

        public string Message()
        {
            return "My first wcf service";
        }

      
       
    }
}
