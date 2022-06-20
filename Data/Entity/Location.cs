using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
    public class Location : BaseEntity
    {
        [StringLength(50), Required]
        public string Name { get; set; }
        [StringLength(30)]
        public string Climate { get; set; }
        [StringLength(30)]
        public string Terrain { get; set; }

        public int Surface_water { get; set; }

        
        public virtual ICollection<Person> Persons { get; set; }
    }

}
