using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.DTOs
{
    public class FilmDTO
    {
        public int idF { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Director { get; set; }
        public string Producer { get; set; }
        public int Release_date { get; set; }
        public double Rt_score { get; set; }

        public int LocationId { get; set; }
        public LocationDTO Location { get; set; }
    }
}
