using System.Collections.Generic;

namespace Turboaz.Domain.Entities
{
    public class FuelType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
    }
}