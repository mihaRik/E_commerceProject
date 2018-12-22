using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace E_commerceProject_Electro.Models
{
    public class E_commerceProjectDbContext : DbContext
    {
        public E_commerceProjectDbContext() : base("E_commerceProjectDb")
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
    }
}