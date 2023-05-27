using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FreshFoodShop.Models;

namespace FreshFoodShop.Data
{
    public class FreshFoodShopContext : DbContext
    {
        public FreshFoodShopContext (DbContextOptions<FreshFoodShopContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; } 
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Orders> Orders { get; set; }
    }
}
