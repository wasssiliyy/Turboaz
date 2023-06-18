using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turboaz.Domain.Entities.Mapping
{
    public class CarMap:EntityTypeConfiguration<Car>
    {
        public CarMap()
        {
            this.HasKey(c => c.Id);

            this.Property(c => c.ColorId).HasColumnName("ColorId");
            this.Property(c => c.ModelId).HasColumnName("ModelId");
            this.Property(c => c.StatusId).HasColumnName("StatusId");
            this.Property(c => c.Year).HasColumnName("Year");
            this.Property(c => c.CityId).HasColumnName("CityId");
            this.Property(p => p.ImagePath).HasColumnName("Image");

            this.Property(c => c.Km)
                .IsRequired();

            this.Property(c => c.Price)
                .IsRequired();
        }
    }
}
