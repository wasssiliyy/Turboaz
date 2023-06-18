using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turboaz.Domain.Entities
{
    public class Status
    {
        public int Id { get; set; }
        public bool IsNew { get; set; }= false;
        public ICollection<Car> Cars { get; set; }
    }
}
