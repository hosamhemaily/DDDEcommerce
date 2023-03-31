using EcommerceDomain;
using EcommerceDomain.ProductTransactions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace EcommercePersistence
{
    public class ProductContext : DbContext
    {

        private readonly IMediator _mediator;

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductTransaction> Producttransactions { get; set; }
        public ProductContext(DbContextOptions<ProductContext> options, IMediator mediator)
          : base(options)
        {
           _mediator= mediator;
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
            _dispatchDomainEvents().GetAwaiter().GetResult();
            var response = base.SaveChanges();
            return response;
        }

        private async Task _dispatchDomainEvents()
        {
            var domainEventEntities = ChangeTracker.Entries<AggregateRoot>()
                .Select(po => po.Entity)
                .Where(po => po.DomainEvents.Any())
                .ToArray();

            foreach (var entity in domainEventEntities)
            {
                var events = entity.DomainEvents.ToArray();
                entity.DomainEvents.Clear();
                foreach (var entityDomainEvent in events)
                    await _mediator.Publish(entityDomainEvent);
            }
        }


    }
}
