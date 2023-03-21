using EcommerceDomain.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommercePersistence.Core
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProductContext _productContext;
        UnitOfWork(ProductContext context) 
        {
            _productContext = context;
        }
        public int Save()
        {
            return _productContext.SaveChanges();

        }
    }
}
