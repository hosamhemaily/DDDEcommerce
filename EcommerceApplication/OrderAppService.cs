using EcommerceContract;
using EcommerceDomain.Products;
using EcommerceDomain.ProductTransactions;
using EcommerceDomain.Repos;
using System.Dynamic;

namespace EcommerceApplication
{
    public class OrderAppService : IOrderAppService
    {
        IrepoProduct _product;
        IrepoProductTransaction _productTransaction;
        IUnitOfWork _unitofwork;

        public OrderAppService(IrepoProduct product, IrepoProductTransaction productTransaction, IUnitOfWork unitofwork)
        {
            _product= product;
            _productTransaction= productTransaction;
            _unitofwork= unitofwork;
        }

        public bool OrderDonePurshase(OrderDTO order)
        {
            //update avialable quantity for the product to be decreased for every product with order quantity
            foreach (var item in order.Products)
            {
                _product.updateQuantity(item.productid, item.quantity);
                var transaction =  ProductTransaction.Create(item.quantity, item.productid, Types.purshase);
                _productTransaction.add(transaction);
                _unitofwork.Save();
            }
            
            throw new NotImplementedException();
        }
    }
}