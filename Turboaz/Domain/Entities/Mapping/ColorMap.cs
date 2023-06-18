using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turboaz.Domain.Entities.Mapping
{
    public class ColorMap:EntityTypeConfiguration<CarsColor>
    {
        public ColorMap()
        {   
            this.HasKey(i => i.Id);

            this.Property(n => n.ColorName)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(true);

            this.HasMany(c =>c.Cars)
                .WithOptional()
                .HasForeignKey(c => c.ColorId);

        }
        
    }
}
