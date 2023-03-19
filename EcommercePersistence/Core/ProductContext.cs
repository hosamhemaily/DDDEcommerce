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
            base.OnModelCreating(modelBuilder);
           // modelBuilder.Entity<Customer>().HasIndex(prop => prop.Email).IsUnique();
           // modelBuilder.Entity<Wallet>().HasIndex(prop => prop.).IsUnique();

        }

        public override int SaveChanges()
        {
            var response = base.SaveChanges();
            return response;
        }


    }
}
