using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using firstnetapp.Models;

namespace firstnetapp.Data
{
    public class firstnetappContext : DbContext
    {
        public firstnetappContext (DbContextOptions<firstnetappContext> options)
            : base(options)
        {
        }

        public DbSet<firstnetapp.Models.Movie> Movie { get; set; }
    }
}
