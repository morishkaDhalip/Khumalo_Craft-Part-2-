using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Khumalo_Craft.Models;

namespace Khumalo_Craft.Data
{
    public class Khumalo_CraftContext : DbContext
    {
        public Khumalo_CraftContext (DbContextOptions<Khumalo_CraftContext> options)
            : base(options)
        {
        }

        public DbSet<Khumalo_Craft.Models.Product> Product { get; set; } = default!;
        public DbSet<Khumalo_Craft.Models.Transaction> Transaction { get; set; } = default!;
        public DbSet<Khumalo_Craft.Models.User> User { get; set; } = default!;
    }
}
