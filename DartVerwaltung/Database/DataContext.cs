using DartVerwaltung.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace DartVerwaltung.Database
{
    public class DataContext : DbContext
    {
        public DbSet<Member> Members {  get; set; }

        public DataContext()
        {
            // Database.EnsureCreated();
            Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=member.db");
            }
        }
    }
}
