using EcommerceDomain;
using EcommerceDomain.Products;
using EcommerceDomain.Products.Events;
using EcommerceDomain.Repos;
using MediatR;
using Microsoft.Extensions.Logging;

namespace EcommerceApplication.EventHandlers
{
    public class ProductTransactionDomainEventHandler : INotificationHandler<ProductTransactionEventAdded>
    {
        private readonly ILogger<ProductTransactionDomainEventHandler> _logger;
        private readonly IProductTransactionManager _repoManager;

        public ProductTransactionDomainEventHandler(ILogger<ProductTransactionDomainEventHandler> logger,
            IProductTransactionManager repoManager)
        {
            _logger = logger;
            _repoManager = repoManager;
        }

        public Task Handle(ProductTransactionEventAdded notification, CancellationToken cancellationToken)
        {
            //var product =
            // Product.DecreaseQuantity(_repo.GetById(notification.productid), notification.quantity);
            //_repo.update(product);
            _repoManager.UpdateInventory(notification.productid, notification.quantity);
            _logger.LogInformation("Product Transaction added and regarding to this we update product stock data: {0}", notification.productid);
            return Task.CompletedTask;
        }
    }
}
