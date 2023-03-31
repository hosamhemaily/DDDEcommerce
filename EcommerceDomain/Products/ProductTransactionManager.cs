using EcommerceDomain.ProductTransactions;
using EcommerceDomain.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceDomain.Products
{
    public class ProductTransactionManager : IProductTransactionManager
    {
        IrepoProduct _repoProduct;
        IrepoProductTransaction _productTransaction;
        IUnitOfWork _unitofwork;
        public ProductTransactionManager(IrepoProduct repoProduct, IrepoProductTransaction productTransaction,
            IUnitOfWork unitofwork)
        {
            _repoProduct = repoProduct;
            _productTransaction = productTransaction;
            _unitofwork = unitofwork;
        }

       
        public bool UpdateInventory(Guid id, int quantity)
        {
            var product = _repoProduct.GetById(id);
            product = Product.DecreaseQuantity(product, quantity);
            _repoProduct.update(product);

            return true;
        }
    }

    public interface IProductTransactionManager
    {
        bool UpdateInventory(Guid id,int quantity);
    }
}
