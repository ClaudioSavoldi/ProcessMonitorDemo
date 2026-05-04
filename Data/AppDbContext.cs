using Microsoft.EntityFrameworkCore;
using ProcessMonitor.Models;

namespace ProcessMonitor.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


        public DbSet<ProductionStep> ProductionSteps { get; set; }
    }
}
