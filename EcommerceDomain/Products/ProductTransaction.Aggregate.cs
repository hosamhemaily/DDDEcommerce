using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommerceDomain.Products;

namespace EcommerceDomain.ProductTransactions
{
    public partial class ProductTransaction : IAggregateRoot
    {
        public static ProductTransaction Create(int quantity,Guid productid,Types types)
        {
            return new ProductTransaction() { 
            Quantity=quantity,
            ProductId = productid,
            transactionDate=DateTime.Now,
            transactiontype = types
            };
        }

    }
}
