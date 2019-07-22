using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PandsMall.Data.Entities
{
    public class Category : BaseEntity
    {
        public IEnumerable<Product> Products { get; set; }
    }
}
