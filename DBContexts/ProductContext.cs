using DotNetCrudMicroservice.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetCrudMicroservice.DBContexts
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = Guid.NewGuid(),
                    Name = "Electronics",
                    Description = "Electronics Items"
                },
                new Category()
                {
                    Id = Guid.NewGuid(),
                    Name = "Clothes",
                    Description = "Dresses"
                },
                new Category()
                {
                    Id = Guid.NewGuid(),
                    Name = "Grocery",
                    Description = "Grocery Items"
                }
                );
        }
    }
}
