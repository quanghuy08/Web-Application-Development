using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Thi.Models;

namespace Thi.Data
{
    public class ThiContext : DbContext
    {
        public ThiContext (DbContextOptions<ThiContext> options)
            : base(options)
        {
        }

        public DbSet<Thi.Models.Employees> Employees { get; set; }
    }
}
