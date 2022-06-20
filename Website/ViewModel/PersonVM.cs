using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Website.ViewModel
{
    public class PersonVM
    {
        public int Id { get; set; }
        [DisplayName("Name:")]
        [Required(ErrorMessage = "*This field is Required")]
        [StringLength(50, ErrorMessage = "Must contain max 50 characters")]
        public string Name { get; set; }
        [DisplayName("Gender:")]
        [StringLength(15, ErrorMessage = "Must contain max 15 characters")]
        public string Gender { get; set; }
        [DisplayName("Age:")]
        public int Age { get; set; }
        [DisplayName("Eye color:")]
        [StringLength(15, ErrorMessage = "Must contain max 15 characters")]
        public string Eye_color { get; set; }
        [DisplayName("Hair color:")]
        [StringLength(15, ErrorMessage = "Must contain max 15 characters")]
        public string Hair_color { get; set; }
        [DisplayName("Film:")]
        public int FilmId { get; set; }
        [DisplayName("Location:")]
        public int LocationId { get; set; } 
        public FilmVM Film { get; set; }
        public LocationVM Location { get; set; }
    }
}