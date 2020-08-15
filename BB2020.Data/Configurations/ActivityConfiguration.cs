using BB2020.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BB2020.Data.Configurations
{
    public class ActivityConfiguration : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id).UseIdentityColumn();
            builder.Property(m => m.Title).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(250).IsRequired();
            builder.Property(x => x.ActivityDate).IsRequired();
            builder.Property(x => x.Time).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Place).HasMaxLength(100).IsRequired();
            builder.Property(x => x.InsertDate).HasColumnType("DateTime").ValueGeneratedOnAdd();
            builder.Property(x => x.UpdatedDate).HasColumnType("DateTime").ValueGeneratedOnUpdate();
            builder.ToTable("Activity");
        }
    }
}
