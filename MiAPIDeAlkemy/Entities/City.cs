using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiAPIDeAlkemy.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Denomination { get; set; }
        public int Population { get; set; }
        public int Area { get; set; }
        
        public Continent Continent { get; set; }
        
        public ICollection<GeographicsIcons> GeographicsIcons { get; set; }
    }
}
