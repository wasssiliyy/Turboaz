using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turboaz.Domain.Entities;

namespace Turboaz.Entities
{
    public class Model
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public int BrandId { get; set; }
        
        public virtual ICollection<Car> Cars{ get; set; }
        public virtual Brand Brand { get; set; }
        
    }
}
