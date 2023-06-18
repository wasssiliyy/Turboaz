using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turboaz.Domain.Entities.Mapping
{
    public class CityMap:EntityTypeConfiguration<City>
    {
        public CityMap()
        {
            this.HasKey(i=>i.Id);

            this.Property(c=>c.CityName)
                .IsRequired()
                .HasMaxLength(40);

            this.HasMany(c => c.Cars)
                .WithOptional()
                .HasForeignKey(c => c.CityId)
                .WillCascadeOnDelete(true);
        }
    }
}
