using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceDomain.Products.Events
{
    public class ProductTransactionEventAdded : IDomainEvent
    {
        public Guid productid;
        public int quantity;
    }
}
