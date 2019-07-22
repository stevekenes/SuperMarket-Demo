using PandsMall.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PandsMall.Data.Repository.Interface
{
    public interface ICategoryRepository : IRepository<Category>
    {
        IEnumerable<Category> GetAllWithProducts();
        Category GetWithProducts(int id);
    }
}
