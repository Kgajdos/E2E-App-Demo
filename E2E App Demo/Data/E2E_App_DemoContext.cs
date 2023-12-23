using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace E2E_App_Demo.Data
{
    public class E2E_App_DemoContext : DbContext
    {
        public E2E_App_DemoContext (DbContextOptions<E2E_App_DemoContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; } = default!;
    }
}
