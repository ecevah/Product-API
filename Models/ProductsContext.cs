using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ProductAPI2.Models
{
    public class ProductContext:IdentityDbContext<AppUser, AppRole, int>
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(new Product() {ProductId = 1, ProductName= "iPhone 11", Price=30000, IsActive = false});
            modelBuilder.Entity<Product>().HasData(new Product() {ProductId = 2, ProductName= "iPhone 12", Price=40000, IsActive = true});
            modelBuilder.Entity<Product>().HasData(new Product() {ProductId = 3, ProductName= "iPhone 13", Price=50000, IsActive = true});
            modelBuilder.Entity<Product>().HasData(new Product() {ProductId = 4, ProductName= "iPhone 14", Price=60000, IsActive = true});
            modelBuilder.Entity<Product>().HasData(new Product() {ProductId = 5, ProductName= "iPhone 15", Price=70000, IsActive = true});


        }

        public DbSet<Product> Products { get; set; }
    }
}