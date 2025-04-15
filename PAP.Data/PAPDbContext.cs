using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PAP.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAP.Data
{
    public class PAPDbContext : DbContext
    {
        public PAPDbContext(DbContextOptions<PAPDbContext> options) : base(options) { }
        public DbSet<Species> Species { get; set; }
        public DbSet<Breed> Breed { get; set; }
        public DbSet<Dog> Dog { get; set; }
        public DbSet<Configuration> Configuration { get; set; }
    }
}