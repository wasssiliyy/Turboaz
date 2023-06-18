using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Turboaz.Domain.Entities
{
    public class CarsColor
    {
        public int Id { get; set; }
        public string ColorName { get; set; }
        public virtual ICollection<Car> Cars { get; set; }

    }
}
