using PandsMall.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PandsMall.Domain.ViewModels
{
    public class ProductEditViewModel
    {
        public Product Product { get; set; }

        public IEnumerable<Category> Categories { get; set; }

    }
}
