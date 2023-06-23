using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turboaz.Domain.Entities.Mapping
{
    public class FuelMap:EntityTypeConfiguration<FuelType>
    {
        public FuelMap()
        {
            this.HasKey(x=> x.Id);

            this.Property(x => x.FuelTypeName).HasColumnName("Name");

            this.HasMany(c => c.Cars)
                .WithOptional()
                .HasForeignKey(c => c.FuelTypeId);
        }
    }
}
