using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turboaz.Entities;

namespace Turboaz.Domain.Entities.Mapping
{
    public class BrandMap:EntityTypeConfiguration<Brand>
    {
        public BrandMap()
        {
            this.HasKey(x => x.Id);

            this.Property(p => p.BrandName)
                .IsRequired()
                .IsUnicode();
          
            this.HasMany(m=>m.Models)
                .WithOptional()
                .HasForeignKey(x => x.BrandId);
        }
    }
}
