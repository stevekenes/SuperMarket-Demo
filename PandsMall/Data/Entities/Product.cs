using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PandsMall.Data.Entities
{
    public class Product : BaseEntity
    {
        public short QuantityInPackage { get; set; }
        public double Price { get; set; }

        public virtual Category Category { get; set; }
        public int CategoryId { get; set; }

       


    }
}
