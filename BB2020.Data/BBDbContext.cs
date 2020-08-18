using BB2020.Core;
using BB2020.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BB2020.Data
{
    public class BBDbContext : DbContext
    {
        public DbSet<Activity> Activity { get; set; }
        public DbSet<Chat> Chat { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<File> File { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserInGroup> UserInGroup { get; set; }
        public BBDbContext( DbContextOptions<BBDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ActivityConfiguration());
            builder.ApplyConfiguration(new ChatConfiguration());
            builder.ApplyConfiguration(new CommentConfiguration());
            builder.ApplyConfiguration(new FileConfiguration());
        }
    }
}
