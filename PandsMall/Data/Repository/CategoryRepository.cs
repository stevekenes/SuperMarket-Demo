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
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(PandsContext context) : base(context){}

        public IEnumerable<Category> GetAllWithProducts()
        {
            return _context.Categories.Include(p => p.Products);
        }

        public Category GetWithProducts(int id)
        {
            return _context.Categories
                .Where(c => c.Id == id)
                .Include(p => p.Products)
                .FirstOrDefault();
        }

        public override void Delete(Category entity)
        {
            var productsToRemove = _context.Products.Where(b => b.Category == entity);

            base.Delete(entity);

            _context.Products.RemoveRange(productsToRemove);

            Save();
        }
    }
}
