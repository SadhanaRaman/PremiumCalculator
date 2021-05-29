using Microsoft.EntityFrameworkCore;
using PremiumCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PremiumCalculator.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Occupations> Occupations { get; set; }
        public DbSet<Ratings> Ratings { get; set; }
    }
}
