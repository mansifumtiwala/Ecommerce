using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Entities
{
    public class Product : BaseEntity
    {
        public Category Category { get; set; }
        public Decimal Price { get; set; }
    }
}
