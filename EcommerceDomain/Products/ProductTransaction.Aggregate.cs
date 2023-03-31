using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using EcommerceDomain.Products;

namespace EcommerceDomain.ProductTransactions
{
    public partial class ProductTransaction : AggregateRoot
    {
        public static ProductTransaction Create(int quantity,Guid productid,Types types)
        {
            var pt = new ProductTransaction()
            {
                Quantity = quantity,
                ProductId = productid,
                transactionDate = DateTime.Now,
                transactiontype = types
            };
            pt.AddDomainEvent(new ProductTransactionEventAdded() { productid=productid,quantity=quantity});
            return pt;
        }

    }
}
