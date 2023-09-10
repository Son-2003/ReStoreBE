using ReStore.Entities;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ReStore.Data
{
        public class StoreContext : DbContext
        {
            public StoreContext(DbContextOptions options) : base(options)
            {
            }
            public DbSet<Product> Products { get; set; }
        }
    
}
