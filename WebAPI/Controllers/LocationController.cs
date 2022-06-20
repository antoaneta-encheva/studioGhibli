using ApplicationService.DTOs;
using ApplicationService.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Messages;

namespace WebAPI.Controllers
{
    public class LocationController : ApiController
    {
        private LocationManagementService locationService = new LocationManagementService();


        [HttpGet]
        public IHttpActionResult Get()
        {
            return Json(locationService.Get());
        }

        //[HttpGet]
        //public IHttpActionResult GetLocationById(int id)
        //{
        //    return Json(locationService.GetLocationById(id));
        //}

        [HttpGet]
        public IHttpActionResult GetLocationById(int id)
        {
            return Json(locationService.GetLocationById(id));
        }

        //[HttpPost]
        //public IHttpActionResult Get(int id)
        //{
        //    return Json(locationService.GetLocationById(id));
        //}


        [HttpPost]
        public IHttpActionResult Save(LocationDTO locationDto)
        {
            //if (!locationDto.Validate())
            //    return Json(new ResponseMessage { Code = 500, Error = "Data is not valid!" });
            ResponseMessage response = new ResponseMessage();

            if (locationService.Save(locationDto))
            {
                response.Code = 200;
                response.Body = "Location is saved.";
            }
            else
            {
                response.Code = 500;
                response.Body = "Location is not saved.";
            }

            return Json(response);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            ResponseMessage response = new ResponseMessage();

            if (locationService.Delete(id))
            {
                response.Code = 200;
                response.Body = "Location is deleted.";
            }
            else
            {
                response.Code = 500;
                response.Body = "Location is not deleted.";
            }

            return Json(response);
        }
    }
}
