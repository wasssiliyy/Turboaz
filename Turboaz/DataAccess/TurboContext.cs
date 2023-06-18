using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Turboaz.Domain.Entities;
using Turboaz.Domain.Entities.Mapping;
using Turboaz.Entities;

namespace Turboaz.DataAccess
{
    public class TurboContext:DbContext
    {
        public TurboContext()
            :base("TurboDb")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BrandMap());
            modelBuilder.Configurations.Add(new CarMap());
            modelBuilder.Configurations.Add(new ModelMap());
            modelBuilder.Configurations.Add(new CityMap());
            modelBuilder.Configurations.Add(new ColorMap());
            modelBuilder.Configurations.Add(new StatusMap());
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<CarsColor> Colors { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Status> Status { get; set; }
    }
}
