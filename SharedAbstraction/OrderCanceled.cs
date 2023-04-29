using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedAbstraction
{
    public class OrderCanceled
    {
        public Guid ID { get; set; }
        public IList<ProductDTO> Products { get; set; }
    }
}
