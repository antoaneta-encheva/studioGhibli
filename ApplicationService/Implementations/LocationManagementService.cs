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
    public class LocationManagementService
    {
        public List<LocationDTO> Get()
        {
            List<LocationDTO> locationsDto = new List<LocationDTO>();

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                foreach (var item in unitOfWork.LocationRepository.Get())
                {
                    locationsDto.Add(new LocationDTO
                    {
                        idL = item.Id,
                        Name = item.Name,
                        Climate = item.Climate, 
                        Surface_water = item.Surface_water   
                       
                    });
                }
            }

            return locationsDto;
        }
        public LocationDTO GetLocationById(int id)
        {
            LocationDTO locationDTO = new LocationDTO();


            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                Location location = unitOfWork.LocationRepository.GetByID(id);
                if (location != null)
                {
                    locationDTO = new LocationDTO
                    {
                        idL = location.Id,
                        Name = location.Name,
                        Climate = location.Climate,
                        Surface_water = location.Surface_water
                    };
                }
            }

            return locationDTO;
        }

        public bool Save(LocationDTO locationDto)
        {
            Location location = new Location
            {
                Id=locationDto.idL,
                Name=locationDto.Name,
                Climate=locationDto.Climate,
                Surface_water=locationDto.Surface_water
            };

            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    if (locationDto.idL == 0)
                        unitOfWork.LocationRepository.Insert(location);
                    else
                        unitOfWork.LocationRepository.Update(location);
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
                    Location location = unitOfWork.LocationRepository.GetByID(id);
                    unitOfWork.LocationRepository.Delete(location);
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
