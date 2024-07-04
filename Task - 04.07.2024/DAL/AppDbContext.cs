using Microsoft.EntityFrameworkCore;
using Task___04._07._2024.Models;

namespace Task___04._07._2024.DAL;

public class AppDbContext : DbContext
{
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Book> Books { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=ABBAS\\SQLEXPRESS;Database=DbLibraryEFCORE;Trusted_Connection=True;TrustServerCertificate=True");
        base.OnConfiguring(optionsBuilder);
    }
}
