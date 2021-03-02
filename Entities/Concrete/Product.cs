using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
     public class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public int ProductName { get; set; }
        public int UnitsInstock { get; set; }
        public int UnitPrice { get; set; }

    }
}
