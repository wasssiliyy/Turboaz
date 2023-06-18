using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turboaz.Domain.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public virtual ICollection<Car> Cars { get; set; }

    }
}
