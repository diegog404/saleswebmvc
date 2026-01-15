using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using saleswebmvccore.Models;

namespace saleswebmvccore.Data
{
    public class saleswebmvccoreContext : DbContext
    {
        public saleswebmvccoreContext (DbContextOptions<saleswebmvccoreContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
