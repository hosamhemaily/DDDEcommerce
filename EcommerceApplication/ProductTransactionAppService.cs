using EcommerceContract;
using EcommerceDomain;
using EcommerceDomain.Products;
using EcommerceDomain.ProductTransactions;
using EcommerceDomain.Repos;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Dynamic;
using System.Text;

namespace EcommerceApplication
{
    public class ProductTransactionAppService : IProductTransactionAppService
    {
        IrepoProduct _product;
        IrepoProductTransaction _productTransaction;
        IUnitOfWork _unitofwork;

        public ProductTransactionAppService(
            IrepoProduct product,
  
            IrepoProductTransaction productTransaction
            , IUnitOfWork unitofwork
            )
        {
            _product= product;
            _productTransaction= productTransaction;
            _unitofwork= unitofwork;
        }

        public bool CreateInTransaction()
        {
            var pt=  ProductTransaction.Create(1, new Guid("08ac377c-ba18-40ab-a496-a5286185036d"), Types.InStock);
            _productTransaction.add(pt);
            _unitofwork.Save();
            return true;
        }
    }
}