using ApplicationService.DTOs;
using Data.Entity;
using Repository.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.Implementations
{
    public class FilmManagementService
    {
          
        public List<FilmDTO> Get()
        {
            List<FilmDTO> filmsDto = new List<FilmDTO>();

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                foreach (var item in unitOfWork.FilmRepository.Get())
                {
                    filmsDto.Add(new FilmDTO
                    {
                        idF= item.Id,
                        Title = item.Title,
                        Description = item.Description,
                        Director=item.Director,
                        Producer=item.Producer,
                        Release_date=item.Release_date,
                        Rt_score=item.Rt_score,
                        Location= new LocationDTO
                        {
                            idL=item.Location.Id,
                            Name=item.Location.Name,    
                            Climate=item.Location.Climate,  
                            Surface_water=item.Location.Surface_water,  
                        }
                    });
                }
            }

            return filmsDto;
        }
        public FilmDTO GetFilmById(int id)
        {
            FilmDTO filmDTO = new FilmDTO();


            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                Film film = unitOfWork.FilmRepository.GetByID(id);
                if (film != null)
                {
                    filmDTO = new FilmDTO
                    {
                        idF = film.Id,
                        Title =film.Title,
                        Description = film.Description,
                        Director = film.Director,
                        Producer = film.Producer,
                        Release_date = film.Release_date,
                        Rt_score = film.Rt_score,
                        LocationId=film.LocationId,
                        Location = new LocationDTO
                        {
                            idL = film.Location.Id,
                            Name = film.Location.Name,
                            Climate = film.Location.Climate,
                            Surface_water = film.Location.Surface_water
                        }
                    };
                }
            }

            return filmDTO;
        }

        public bool Save(FilmDTO filmDto)
        {
            
            Film film = new Film
            {
                Id=filmDto.idF,
                Title = filmDto.Title,
                Description = filmDto.Description,
                Director = filmDto.Director,
                Producer = filmDto.Producer,
                Release_date = filmDto.Release_date,
                Rt_score = filmDto.Rt_score,
                LocationId= filmDto.Location.idL,
            };

            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                      if (film.Id == 0)
                        unitOfWork.FilmRepository.Insert(film);
                   else
                       unitOfWork.FilmRepository.Update(film);
                    unitOfWork.Save();
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    Film film = unitOfWork.FilmRepository.GetByID(id);
                    unitOfWork.FilmRepository.Delete(film);
                    unitOfWork.Save();
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
