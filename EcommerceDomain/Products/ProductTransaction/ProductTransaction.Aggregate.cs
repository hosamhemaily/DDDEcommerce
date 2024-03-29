﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using EcommerceDomain.Products;
using EcommerceDomain.Products.Events;

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
            //after create product transaction , automaically products quantity will decreased assyming it is decrease operation
            //update quantity of product 
            pt.AddDomainEvent(new ProductTransactionEventAdded() { productid=productid,quantity=quantity});
            return pt;
        }

    }
}
