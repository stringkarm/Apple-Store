using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Apple_Store.Models;

namespace Apple_Store.Data
{
    public class Apple_StoreContext : DbContext
    {
        public Apple_StoreContext (DbContextOptions<Apple_StoreContext> options)
            : base(options)
        {
        }

        public DbSet<Apple_Store.Models.Products> Products { get; set; } = default!;
    }
}
