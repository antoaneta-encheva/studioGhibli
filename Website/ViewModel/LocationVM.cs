using ApplicationService.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
//using Website.LocationReference;

namespace Website.ViewModel
{
    public class LocationVM
    {
        public int idL { get; set; }
        [DisplayName("Name:")]
        [Required(ErrorMessage = "*This field is Required")]
        [StringLength(50, ErrorMessage = "Must contain max 50 characters")]
        public string Name { get; set; }
        [DisplayName("Climate:")]
        [StringLength(30, ErrorMessage = "Must contain max 30 characters")]
        public string Climate { get; set; }
        [DisplayName("Surface water:")]
        public int Surface_water { get; set; }

        public LocationVM() { }

        public LocationVM(LocationDTO locationDto)
        {
            idL = locationDto.idL;
            Name = locationDto.Name;
            Climate = locationDto.Climate;
            Surface_water = locationDto.Surface_water;
        }
    }
}