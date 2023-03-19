﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceDomain.Repos
{
    public interface IrepoProduct
    {
        public bool add(Product product);
        public bool update();
        public bool delete();
        public IList<Product> GetAll();
        public IList<Product> GetAllByIds(Guid[] ids);
        public Product GetById();
    }
}
