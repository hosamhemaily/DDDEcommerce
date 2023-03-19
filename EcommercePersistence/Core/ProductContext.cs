using EcommerceDomain;
using Microsoft.EntityFrameworkCore;

namespace EcommercePersistence
{
    public class ProductContext : DbContext
    {


        public DbSet<Product> Products { get; set; }
        public ProductContext(DbContextOptions<ProductContext> options)
          : base(options)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var product1 = Product.Create("P1", 10, new Guid("08ac377c-ba18-40ab-a496-a5286185036d"),200);
            modelBuilder.Entity<Product>().HasData(product1);
            var product2 = Product.Create("P2", 10, new Guid("cc4b3750-9b7d-4a43-9c99-045642717cca"),100);
            modelBuilder.Entity<Product>().HasData(product2);
        }

        public override int SaveChanges()
        {
            var response = base.SaveChanges();
            return response;
        }


    }
}
