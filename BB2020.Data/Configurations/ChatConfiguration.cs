using BB2020.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BB2020.Data.Configurations
{
    public class ChatConfiguration : IEntityTypeConfiguration<Chat>
    {
        public void Configure(EntityTypeBuilder<Chat> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id).UseIdentityColumn();
            builder.Property(m => m.Message).HasMaxLength(500).IsRequired();
            builder.Property(m => m.InsertDate).HasColumnType("DateTime").ValueGeneratedOnAdd();
            builder.ToTable("Chat");
        }
    }
}
