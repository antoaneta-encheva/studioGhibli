using ApplicationService.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Website.ViewModel
{
    public class FilmVM
    {
        public int idF { get; set; }
        [DisplayName("Title:")]
        [Required(ErrorMessage = "*This field is Required")]
        [StringLength(50, ErrorMessage = "Must contain max 50 characters")]
        public string Title { get; set; }
        [DisplayName("Description:")]
        [StringLength(250, ErrorMessage = "Must contain max 250 characters")]
        public string Description { get; set; }
        [DisplayName("Director:")]
        [StringLength(30, ErrorMessage = "Must contain max 30 characters")]
        public string Director { get; set; }
        [DisplayName("Producer:")]
        [Required(ErrorMessage = "*This field is Required")]
        [StringLength(30, ErrorMessage = "Must contain max 30 characters")]
        public string Producer { get; set; }
        [DisplayName("Release date:")]
        public int Release_date { get; set; }
        [DisplayName("Rate:")]
        public double Rt_score { get; set; }
        [DisplayName("Location:")]
        public  int LocationId { get; set; }   
        public LocationVM Location { get; set; }

        public FilmVM() { }

        public FilmVM(FilmDTO filmDto)
        {
            idF = filmDto.idF;
            Title = filmDto.Title;
            Description = filmDto.Description;
            Director = filmDto.Director;
            Producer = filmDto.Producer;
            Release_date=filmDto.Release_date;
            Rt_score=filmDto.Rt_score;
            LocationId = filmDto.LocationId;
            Location = new LocationVM();
        }
    }
}