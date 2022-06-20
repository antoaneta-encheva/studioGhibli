using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity
{
    public class Person : BaseEntity
    {
        [StringLength(50), Required]
        public string Name { get; set; }
        [StringLength(15)]
        public string Gender { get; set; }
        public int Age { get; set; }
        [StringLength(15)]
        public string Eye_color { get; set; }
        [StringLength(15)]
        public string Hair_color { get; set; }
        public int Filmid { get; set; }
        public virtual Film film { get; set; }

        public int Locationid { get; set; }
        public virtual Location Location { get; set; }
    }

}
