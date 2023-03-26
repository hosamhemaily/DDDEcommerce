using EcommerceDomain;
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

        public Product GetById(Guid id)
        {
            return _context.Products.Find(id);
        }

        public bool update(Product product)
        {
            _context.Products.Update(product);
            return true;
        }

        //public bool updateQuantity(Guid id, int quantity)
        //{
        //    var result =  _context.Products.Find(id);
        //    result.CurrentQuantity = 100;
        //    _context.Products.Update(result);
        //    throw new NotImplementedException();
        //}
    }
}
