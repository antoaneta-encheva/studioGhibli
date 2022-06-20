using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
    public class Film:BaseEntity
    {
        [StringLength(50), Required]
        public string Title { get; set; }
        [StringLength(250)]
        public string Description { get; set; }
        [StringLength(30)]
        public string Director { get; set; }
        [StringLength(30), Required]
        public string Producer { get; set; }  
      public int Release_date { get; set; } 
      public int Running_time { get; set; } 
      public double Rt_score { get; set; }
        public virtual ICollection<Person> Persons { get; set; }

        public int LocationId { get; set; }
        public virtual Location Location { get; set; }



    }
}
