using ApplicationService.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IFilm" in both code and config file together.
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ILocation" in both code and config file together.
    [ServiceContract]
    public interface IFilm
    {
        [OperationContract]
        List<FilmDTO> GetFilms();

        [OperationContract]
        FilmDTO GetFilmByID(int id);

        [OperationContract]
        string PostFilm(FilmDTO filmDto);

        [OperationContract]
        string PutFilm(FilmDTO filmDto);

        [OperationContract]
        string DeleteFilm(int id);

        [OperationContract]
        string Message();
    }
}