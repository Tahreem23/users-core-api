using Microsoft.EntityFrameworkCore;
using Urduville.Models;

namespace Urduville.Data
{
    public class UserDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public UserDbContext() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure additional constraints or relationships here
            // For example, you might want to configure the uniqueness of the email field
            modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // Replace with your database connection string
            options.UseSqlServer("Server=localhost;Database=MyDatabase;User Id=sa;Password=MyPassword;");

            base.OnConfiguring(options);
        }
    }
}

