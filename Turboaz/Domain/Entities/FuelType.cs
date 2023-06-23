using System.Collections.Generic;

namespace Turboaz.Domain.Entities
{
    public class FuelType
    {
        public int Id { get; set; }
        public string FuelTypeName { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
    }
}