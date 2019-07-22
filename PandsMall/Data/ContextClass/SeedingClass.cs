using Microsoft.EntityFrameworkCore;
using PandsMall.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PandsMall.Data.ContextClass
{
    public static class SeedingClass
    {
        public static void SeedProductData(this ModelBuilder builder)
        {
            builder.Entity<Product>().HasData(
                new Product[]
                {
                    new Product{ Id = 1, Name = "Delta Soap", QuantityInPackage = 6, UnitOfMeasurement = EUnitOfMeasurement.Gram, CategoryId = 1, Price = 750, DateCreated = DateTime.Now, DateUpdated = DateTime.Now},
                    new Product{ Id = 2, Name = "Apple", QuantityInPackage = 6, UnitOfMeasurement = EUnitOfMeasurement.Gram, CategoryId = 2, Price = 500, DateCreated = DateTime.Now, DateUpdated = DateTime.Now},
                    new Product{ Id = 3, Name = "Pepsi", QuantityInPackage = 12, UnitOfMeasurement = EUnitOfMeasurement.Litre, CategoryId = 3, Price = 1500, DateCreated = DateTime.Now, DateUpdated = DateTime.Now},
                    new Product{ Id = 4, Name = "Gas Cooker", QuantityInPackage = 1, UnitOfMeasurement = EUnitOfMeasurement.Kilogram, CategoryId = 4, Price = 3000, DateCreated = DateTime.Now, DateUpdated = DateTime.Now},
                    new Product{ Id = 5, Name = "Meat Pie", QuantityInPackage = 1, UnitOfMeasurement = EUnitOfMeasurement.Gram, CategoryId = 5, Price = 300, DateCreated = DateTime.Now, DateUpdated = DateTime.Now},
                });
        }

        public static void SeedCategoryData(this ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
                new Category[]
                {
                    new Category{ Id = 1, Name = "Toiletries", DateCreated = DateTime.Now, DateUpdated = DateTime.Now},
                    new Category{ Id = 2, Name = "Fruits", DateCreated = DateTime.Now, DateUpdated = DateTime.Now},
                    new Category{ Id = 3, Name = "Drinks", DateCreated = DateTime.Now, DateUpdated = DateTime.Now},
                    new Category{ Id = 4, Name = "Kitchen", DateCreated = DateTime.Now, DateUpdated = DateTime.Now},
                    new Category{ Id = 5, Name = "Bakeries", DateCreated = DateTime.Now, DateUpdated = DateTime.Now},
                });
        }
    }
}
