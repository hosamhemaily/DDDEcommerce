using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceContract
{
    public class OrderDTO
    {
        public Guid ID { get; set; }
        public IList<ProductDTO> Products { get; set; }
    }
}
