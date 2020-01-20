using Microsoft.EntityFrameworkCore;
using Persistance.Models;

namespace Persistance
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(
                "Data Source=Activities.db");
        }

        public DbSet<Activity> Activities { get; set; }
    }
}
