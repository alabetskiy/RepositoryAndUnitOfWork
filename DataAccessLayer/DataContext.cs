using BusinessLogicLayer.BusinessModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
   public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Many - to - many relationships without an entity class to 
            // represent the join table are not yet supported. 
            // However, you can represent a many-to-many relationship by including
            // an entity class for the join table and mapping two separate one-to-many relationships. 
            // https://docs.microsoft.com/en-us/ef/core/modeling/relationships
            // https://www.learnentityframeworkcore.com/configuration/many-to-many-relationship-configuration

            modelBuilder.Entity<PostTag>()
                .HasKey(bc => new { bc.PostId, bc.TagId });

            modelBuilder.Entity<PostTag>()
                .HasOne(bc => bc.Tag)
                .WithMany(b => b.Posts)
                .HasForeignKey(bc => bc.TagId);

            modelBuilder.Entity<PostTag>()
                .HasOne(bc => bc.Post)
                .WithMany(c => c.Tags)
                .HasForeignKey(bc => bc.PostId);
        }
    }
}
