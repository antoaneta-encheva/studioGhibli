using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.DTOs
{
    public class PersonDTO
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Eye_color { get; set; }
        public string Hair_color { get; set; }

        public int FilmId { get; set; }

        public int LocationId { get; set; }

        public  FilmDTO Film { get; set; }
        public LocationDTO Location { get; set; }

    }
}
