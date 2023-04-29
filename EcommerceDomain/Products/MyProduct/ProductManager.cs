using EcommerceDomain.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceDomain.Products.MyProduct
{
    public interface IProductManager
    {
        public bool DecreaseQuantity(Guid productid, int quantity);
        public bool IncreaseQuantity(Guid productid, int quantity);
    }

    public class ProductManager : IProductManager
    {
        private readonly IrepoProduct _irepoProduct;
        public ProductManager(IrepoProduct irepoProduct) {
            _irepoProduct = irepoProduct;

        }

        

        public bool DecreaseQuantity(Guid productid,int quantity)
        {
            var product = _irepoProduct.GetById(productid);
            product= Product.DecreaseQuantity(product, quantity);
            _irepoProduct.update(product);
            return true;
        }

        public bool IncreaseQuantity(Guid productid, int quantity)
        {
            var product = _irepoProduct.GetById(productid);
            product = Product.IncreaseQuantity(product, quantity);
            _irepoProduct.update(product);
            return true;
        }
    }
}
