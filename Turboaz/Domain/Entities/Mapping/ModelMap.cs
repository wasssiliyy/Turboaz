using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Turboaz.Entities;

namespace Turboaz.Domain.Entities.Mapping
{
    public class ModelMap:EntityTypeConfiguration<Model>
    {
        public ModelMap()
        {
            this.HasKey(i => i.Id);

            this.HasMany(m => m.Cars)
                .WithOptional()
                .HasForeignKey(c => c.ModelId)
                .WillCascadeOnDelete();

            this.Property(m => m.ModelName)
            .IsRequired()
            .HasMaxLength(30)
            
            .IsUnicode(true);
        }
    }
}
