using PandsMall.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PandsMall.Data.Repository.Interface
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetAllWithCategory();
        IEnumerable<Product> FindWithCategory(Func<Product, bool> predicate);
       
    }
}
