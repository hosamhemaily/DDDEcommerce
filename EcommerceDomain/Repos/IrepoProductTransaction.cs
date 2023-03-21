using EcommerceDomain.ProductTransactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceDomain.Repos
{
    public interface IrepoProductTransaction
    {
        public bool add(ProductTransaction product);
        public bool update();
        public bool delete();
        public IList<ProductTransaction> GetAll();
        public IList<ProductTransaction> GetAllByIds(Guid[] ids);
        public ProductTransaction GetById();
    }
}
