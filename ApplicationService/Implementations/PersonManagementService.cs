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
    public class PersonManagementService
    {
        public List<PersonDTO> Get()
        {
            List<PersonDTO> personsDto = new List<PersonDTO>();

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                foreach (var item in unitOfWork.PersonRepository.Get())
                {
                    personsDto.Add(new PersonDTO
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Gender = item.Gender,
                        Age = item.Age,
                        Eye_color = item.Eye_color,
                        Hair_color = item.Hair_color,
                        FilmId=item.Filmid,
                        LocationId=item.Locationid,
                        Film=new FilmDTO
                        {
                            idF=item.film.Id,
                            Title=item.film.Title,
                            Description=item.film.Description,
                            Director=item.film.Director,   
                            Producer=item.film.Producer,    
                            Release_date=item.film.Release_date,    
                            Rt_score=item.film.Rt_score,
                            LocationId=item.film.LocationId,
                            Location = new LocationDTO
                            {
                                idL = item.film.Location.Id,
                                Name = item.film.Location.Name,
                                Climate = item.film.Location.Climate,
                                Surface_water = item.film.Location.Surface_water,
                            }
                        },
                        Location = new LocationDTO
                        {
                            idL = item.Location.Id,
                            Name = item.Location.Name,
                            Climate = item.Location.Climate,
                            Surface_water = item.Location.Surface_water,
                        }
                    });
                }
            }

            return personsDto;
        }

        public PersonDTO GetPersonById(int id)
        {
            PersonDTO personDTO = new PersonDTO();


            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                Person person = unitOfWork.PersonRepository.GetByID(id);
                if (person != null)
                {
                    personDTO = new PersonDTO
                    {
                        Id = person.Id,
                        Name = person.Name,
                        Gender = person.Gender,
                        Age = person.Age,
                        Eye_color = person.Eye_color,
                        Hair_color = person.Hair_color,
                        FilmId = person.Filmid,
                        LocationId = person.Locationid,
                        Film = new FilmDTO
                        {
                            idF = person.film.Id,
                            Title = person.film.Title,
                            Description = person.film.Description,
                            Director = person.film.Director,
                            Producer = person.film.Producer,
                            Release_date = person.film.Release_date,
                            Rt_score = person.film.Rt_score,
                            LocationId = person.film.LocationId,
                            Location = new LocationDTO
                            {
                                idL = person.film.Location.Id,
                                Name = person.film.Location.Name,
                                Climate = person.film.Location.Climate,
                                Surface_water = person.film.Location.Surface_water,
                            }
                        },
                        Location = new LocationDTO
                        {
                            idL = person.Location.Id,
                            Name = person.Location.Name,
                            Climate = person.Location.Climate,
                            Surface_water = person.Location.Surface_water,
                        }
                    };
                }
            }

            return personDTO;
        }

        public bool Save(PersonDTO personDto)
        {
            Person person = new Person
            {
                Id = personDto.Id,
                Name = personDto.Name,
               Gender = personDto.Gender,
               Age = personDto.Age, 
               Eye_color = personDto.Eye_color,
               Hair_color = personDto.Hair_color,   
               Filmid=personDto.Film.idF,
               Locationid=personDto.Location.idL
            };

            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    if (person.Id == 0)
                        unitOfWork.PersonRepository.Insert(person);
                    else
                        unitOfWork.PersonRepository.Update(person);
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
                    Person person = unitOfWork.PersonRepository.GetByID(id);
                    unitOfWork.PersonRepository.Delete(person);
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
