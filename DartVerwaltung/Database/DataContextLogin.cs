using DartVerwaltung.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace DartVerwaltung.Database
{
    public class DataContextLogin : DbContext
    {
        public DbSet<Login> Logins { get; set; }

        public DataContextLogin()
        {
            // Database.EnsureCreated();
            Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=login.db");
            }
        }
    }
}
