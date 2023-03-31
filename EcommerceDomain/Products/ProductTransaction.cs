using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommerceDomain.Products;

namespace EcommerceDomain.ProductTransactions
{
    public partial class ProductTransaction :AggregateRoot
    {
        public Guid ProductId { get; protected set; }
        public Types transactiontype { get; protected set; }
        public int Quantity { get; protected set; }
        public DateTime transactionDate { get; protected set; }
    }
}
