using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MensWearBackend.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MensWearBackend.Infrastructure
{
    public class ClothStoreDbContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }


        public ClothStoreDbContext(DbContextOptions<ClothStoreDbContext> options): base(options)
        {
            Database.EnsureCreated();
        }
    }
}
