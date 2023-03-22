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
        public bool UpdateInventory(ProductTransaction productTransaction)
        {
            var product = _repoProduct.GetById(productTransaction.ProductId);
            product = Product.DecreaseQuantity(product, productTransaction.Quantity);
            _repoProduct.update(product);
            _productTransaction.add(productTransaction);
            _unitofwork.Save();
            return true;
        }
    }

    public interface IProductTransactionManager
    {
        bool UpdateInventory(ProductTransaction transaction);
    }
}
