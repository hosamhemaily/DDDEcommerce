﻿using EcommerceDomain;
using EcommerceDomain.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommercePersistence.ProductManagment
{
    public class RepoProduct : IrepoProduct
    {
        ProductContext _context;
        public RepoProduct(ProductContext context)
        {
            _context = context;
        }
        public bool add(Product product)
        {
            throw new NotImplementedException();
        }

        public bool delete()
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public IList<Product> GetAllByIds(Guid[] ids)
        {
            throw new NotImplementedException();
        }

        public Product GetById()
        {
            throw new NotImplementedException();
        }

        public bool update()
        {
            throw new NotImplementedException();
        }
    }
}