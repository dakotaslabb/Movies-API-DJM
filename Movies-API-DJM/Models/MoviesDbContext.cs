using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies_API_DJM.Models
{
    public class MoviesDbContext : DbContext
    {
        public DbSet<Movies> movies { get; set; }
        public virtual DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=MOISE\SQLEXPRESS;Initial Catalog=MoviesDb; Trusted_Connection=true;");
        }
    }
}

