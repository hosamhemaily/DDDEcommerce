using EcommerceDomain;
using EcommerceDomain.ProductTransactions;
using EcommerceDomain.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommercePersistence.ProductManagment
{
    public class repoProductTransaction : IrepoProductTransaction
    {
        ProductContext _context;
        public repoProductTransaction(ProductContext context)
        {
            _context = context;
        }

        public bool add(ProductTransaction product)
        {
            _context.Producttransactions.Add(product);
            return true;
        }

        public bool delete()
        {
            throw new NotImplementedException();
        }

        public IList<ProductTransaction> GetAll()
        {
            throw new NotImplementedException();
        }

        public IList<ProductTransaction> GetAllByIds(Guid[] ids)
        {
            throw new NotImplementedException();
        }

        public ProductTransaction GetById()
        {
            throw new NotImplementedException();
        }

        public bool update()
        {
            throw new NotImplementedException();
        }
    }
}
