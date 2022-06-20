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
    public class FilmController : ApiController
    {
        private FilmManagementService filmService = new FilmManagementService();


        [HttpGet]
        public IHttpActionResult Get()
        {
            return Json(filmService.Get());
        }


        //[HttpPost]
        //public IHttpActionResult Get(int id)
        //{
        //    return Json(filmService.GetById(id));
        //}
        [HttpGet]
        public IHttpActionResult GetFilmById(int id)
        {
            return Json(filmService.GetFilmById(id));
        }

        [HttpPost]
        public IHttpActionResult Save(FilmDTO filmDto)
        {
            //if (!locationDto.Validate())
            //    return Json(new ResponseMessage { Code = 500, Error = "Data is not valid!" });
            ResponseMessage response = new ResponseMessage();

            if (filmService.Save(filmDto))
            {
                response.Code = 200;
                response.Body = "Film is saved.";
            }
            else
            {
                response.Code = 500;
                response.Body = "Film is not saved.";
            }

            return Json(response);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            ResponseMessage response = new ResponseMessage();

            if (filmService.Delete(id))
            {
                response.Code = 200;
                response.Body = "Film is deleted.";
            }
            else
            {
                response.Code = 500;
                response.Body = "Film is not deleted.";
            }

            return Json(response);
        }
    }
}