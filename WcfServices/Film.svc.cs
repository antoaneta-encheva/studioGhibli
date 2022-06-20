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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Film" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Film.svc or Film.svc.cs at the Solution Explorer and start debugging.
    public class Film : IFilm
    {
        #region Fields
        private FilmManagementService service = new FilmManagementService();
        #endregion

        public List<FilmDTO> GetFilms()
        {
            return service.Get();
        }
        public FilmDTO GetFilmByID(int id)
        {
            return service.GetFilmById(id);
        }
        public string PostFilm(FilmDTO filmDto)
        {
            if (!service.Save(filmDto))
                return "Film is not inserted";

            return "Film is inserted";
        }

        public string PutFilm(FilmDTO filmDto)
        {
            throw new NotImplementedException();
        }

        public string DeleteFilm(int id)
        {
            if (!service.Delete(id))
                return "Fukm is not deleted";

            return "Film is deleted";
        }

        public string Message()
        {
            return "My first wcf service";
        }

    }
}
