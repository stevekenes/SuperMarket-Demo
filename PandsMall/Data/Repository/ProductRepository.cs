using Microsoft.EntityFrameworkCore;
using PandsMall.Data.ContextClass;
using PandsMall.Data.Entities;
using PandsMall.Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PandsMall.Data.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(PandsContext context) : base(context){}

        public IEnumerable<Product> FindWithCategory(Func<Product, bool> predicate)
        {
            return _context.Products
                .Include(c => c.Category)
                .Where(predicate);
        }

        public IEnumerable<Product> GetAllWithCategory()
        {
            return _context.Products.Include(a => a.Category);
        }
    }
}
