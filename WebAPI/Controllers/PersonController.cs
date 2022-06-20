using ApplicationService.Implementations;
using System;
using ApplicationService.DTOs;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Messages;

namespace WebAPI.Controllers
{
    public class PersonController : ApiController
    {
        private PersonManagementService personService = new PersonManagementService();


        [HttpGet]
        public IHttpActionResult Get()
        {
            return Json(personService.Get());
        }


        //[HttpPost]
        //public IHttpActionResult Get(int id)
        //{
        //    return Json(personService.GetById(id));
        //}

        [HttpGet]
        public IHttpActionResult GetPerosnById(int id)
        {
            return Json(personService.GetPersonById(id));
        }

        [HttpPost]
        public IHttpActionResult Save(PersonDTO personDto)
        {
            //if (!locationDto.Validate())
            //    return Json(new ResponseMessage { Code = 500, Error = "Data is not valid!" });
            ResponseMessage response = new ResponseMessage();

            if (personService.Save(personDto))
            {
                response.Code = 200;
                response.Body = "Person is saved.";
            }
            else
            {
                response.Code = 500;
                response.Body = "Person is not saved.";
            }

            return Json(response);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            ResponseMessage response = new ResponseMessage();

            if (personService.Delete(id))
            {
                response.Code = 200;
                response.Body = "Person is deleted.";
            }
            else
            {
                response.Code = 500;
                response.Body = "Person is not deleted.";
            }

            return Json(response);
        }
    }
}