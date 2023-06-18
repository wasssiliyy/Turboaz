﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turboaz.Domain.Entities.Mapping
{
    public class StatusMap:EntityTypeConfiguration<Status>
    {
        public StatusMap()
        {
            this.HasKey(x => x.Id);

            this.Property(i => i.IsNew)
                .IsRequired();

            this.HasMany(m => m.Cars)
                .WithOptional()
                .HasForeignKey(c => c.StatusId);
        }
    }
}
