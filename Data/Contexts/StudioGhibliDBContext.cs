using Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Contexts
{
    public class StudioGhibliDBContext:DbContext
    {
       public DbSet<Film> Films { get; set; }
       public DbSet<Location> Locations { get; set; }
        public DbSet<Person> Persons { get; set; }
    }
}
