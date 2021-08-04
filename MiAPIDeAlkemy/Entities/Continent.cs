using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiAPIDeAlkemy.Entities
{
    public class Continent
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Denomination { get; set; }
      
        public ICollection<City> Cities { get; set; }
    }
}
