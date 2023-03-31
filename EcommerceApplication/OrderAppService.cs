using EcommerceContract;
using EcommerceDomain;
using EcommerceDomain.Products;
using EcommerceDomain.Products.MyProduct;
using EcommerceDomain.ProductTransactions;
using EcommerceDomain.Repos;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Dynamic;
using System.Text;

namespace EcommerceApplication
{
    public class OrderAppService : IOrderAppService
    {
        IProductManager _product;
        //IrepoProductTransaction _productTransaction;
        IUnitOfWork _unitofwork;

        public OrderAppService(
            IProductManager product
  
            //IrepoProductTransaction productTransaction
            , IUnitOfWork unitofwork
            )
        {
            _product= product;
            //_productTransaction= productTransaction;
            _unitofwork= unitofwork;
        }

        public bool OrderDonePurshase(OrderDTO order)
        {
          
            //update avialable quantity for the product to be decreased for every product with order quantity
            foreach (var item in order.Products)
            {
                //var product =  _product.GetById(item.productid);
                //var p =  Product.DecreaseQuantity(product, item.quantity);
                //_product.update(p);
                //var transaction = ProductTransaction.Create(item.quantity, item.productid, Types.purshase);
                //_productTransaction.add(transaction);
                _product.DecreaseQuantity(item.productid, item.quantity);
                
            }
            _unitofwork.Save();
            // throw new NotImplementedException();
            return true;
        }
    }
}