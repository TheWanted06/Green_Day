using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Green_Day.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Green_Day.Data
{
    public class Green_DayContext : DbContext
    {
        public Green_DayContext (DbContextOptions<Green_DayContext> options)
            : base(options)
        {
        }

        public DbSet<Green_Day.Models.Product> Product { get; set; } = default!;

        public DbSet<Green_Day.Models.Users>? Users { get; set; }
    }
}
