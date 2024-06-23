using Microsoft.EntityFrameworkCore;
using POEPart2.Models;
using System.Collections.Generic;

namespace POEPartOne.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Products> products { get; set; }
       
    }
}
