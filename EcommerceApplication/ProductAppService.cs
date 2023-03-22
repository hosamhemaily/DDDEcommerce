using EcommerceContract;
using EcommerceDomain.Repos;
using System.Dynamic;

namespace EcommerceApplication
{
    public class ProductAppService : IProductAppService
    {
        IrepoProduct _product;
        
        public ProductAppService(IrepoProduct product)
        {
            _product= product;
        }
        public List<ProductGetBase> Get()
        {
            return _product.GetAll().Select(x=>new ProductGetBase { Catregory = x.Catregory?.Id,
            CurrentQuantity= x.CurrentQuantity,
            ExpiryDate= x.ExpiryDate,
            MinimumQuantity= x.MinimumQuantity,
            Name= x.Name,
            ProductId=x.Id,
            SellPrice = x.SellPrice
            }).ToList();
        }

        
    }
}