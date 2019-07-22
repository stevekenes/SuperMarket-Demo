﻿using Microsoft.EntityFrameworkCore;
using PandsMall.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PandsMall.Data.ContextClass
{
    public class PandsContext : DbContext
    {
        public PandsContext(DbContextOptions<PandsContext> options) : base(options){}

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.SeedProductData();
            builder.SeedCategoryData();
        }
    }
}
