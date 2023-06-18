using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turboaz.Entities
{
    public class Brand
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public virtual ICollection<Model> Models { get; set; }
    }
}
