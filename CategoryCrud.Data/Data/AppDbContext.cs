using Microsoft.EntityFrameworkCore;
using RazorAppModels;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace RazorAppData.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Phones", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Laptops", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Screens", DisplayOrder = 3 }

                );
        }

    }

}
