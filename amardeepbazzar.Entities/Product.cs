using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amardeepbazzar.Entities
{
    public class Product : BaseEntity
    {
        public decimal price { get; set; }
        public Category Category { get; set; }
    }
}
