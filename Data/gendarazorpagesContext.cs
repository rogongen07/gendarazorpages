#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using gendarazorpages.Pages.Dances;

namespace gendarazorpages.Data
{
    public class gendarazorpagesContext : DbContext
    {
        public gendarazorpagesContext (DbContextOptions<gendarazorpagesContext> options)
            : base(options)
        {
        }

        public DbSet<gendarazorpages.Pages.Dances.Dances> Dances { get; set; }
    }
}
