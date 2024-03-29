﻿using EcommerceDomain.ProductTransactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceDomain
{
    public partial class Product : AggregateRoot
    {
        public string? Name { get; protected set; }
        public decimal? MinimumQuantity { get; protected set; }
        public decimal? CurrentQuantity { get; protected set; }
        public Category? Catregory { get; protected set; }
        public DateTime? ExpiryDate { get; protected set; }
        public decimal SellPrice { get; protected set; }

        public IList<ProductTransaction>? ProductTransactions { get;protected set;}

     
    }
}
