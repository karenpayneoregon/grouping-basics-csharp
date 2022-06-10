using Microsoft.EntityFrameworkCore;
using NoForesight.Models;
using static ConfigurationLibrary.Classes.ConfigurationHelper;

namespace NoForesight.Data
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
