using MastersMVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
   

namespace MastersMVC.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Master> Masters { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Order> Orders { get; set; }
      
    }
}
