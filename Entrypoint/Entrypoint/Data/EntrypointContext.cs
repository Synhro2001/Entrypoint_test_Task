using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Entrypoint.Models;

namespace Entrypoint.Data
{
    public class EntrypointContext : DbContext
    {
        public EntrypointContext (DbContextOptions<EntrypointContext> options)
            : base(options)
        {
        }

        public DbSet<Entrypoint.Models.Client> Client { get; set; } = default!;

        public DbSet<Entrypoint.Models.Product> Product { get; set; } = default!;

        public DbSet<Entrypoint.Models.Order> Order { get; set; } = default!;
    }
}
