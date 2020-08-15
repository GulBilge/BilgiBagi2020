using BB2020.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BB2020.Data.Configurations
{
    public class FileConfiguration : IEntityTypeConfiguration<File>
    {
        public void Configure(EntityTypeBuilder<File> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id).UseIdentityColumn();
            builder.Property(m => m.InsertDate).ValueGeneratedOnAdd();
            builder.Property(m => m.Title).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Path).HasMaxLength(250).IsRequired();
            builder.ToTable("File");

        }
    }
}
