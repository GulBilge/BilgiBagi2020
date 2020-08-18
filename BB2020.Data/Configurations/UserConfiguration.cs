using BB2020.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BB2020.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id).UseIdentityColumn();
            builder.Property(m => m.FirstName);
            builder.Property(m => m.LastName);
            builder.Property(m => m.InsertDate).ValueGeneratedOnAdd();
            builder.Property(m => m.Password);
            builder.Property(m => m.PhotoPath);
            builder.Property(m => m.TcNo);
            builder.Property(m => m.UpdatedDate).ValueGeneratedOnAdd();
        }
    }
}
