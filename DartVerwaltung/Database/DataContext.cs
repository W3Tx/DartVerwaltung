using DartVerwaltung.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace DartVerwaltung.Database
{
    public class DataContext : DbContext
    {
        // Definiert die Tabelle "Members" in der Datenbank
        public DbSet<Member> Members {  get; set; }

        // Konstruktor der DataContext-Klasse
        public DataContext()
        {
            // Database.EnsureCreated();
            Database.Migrate();
        }

        // Konfiguriert die Datenbankverbindung
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=member.db");
            }
        }
    }
}
