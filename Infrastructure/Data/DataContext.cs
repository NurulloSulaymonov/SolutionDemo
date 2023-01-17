using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    
      
    }

    public DbSet<Book> Books { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Company> Companies { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>().HasData(
            new List<Book>()
            {
                new Book(11,"The Hobbit", "J.R.R. Tolkien", 1937),
                new Book(12,"The Lord of the Rings", "J.R.R. Tolkien", 1954),
                new Book(13,"The Silmarillion", "J.R.R. Tolkien", 1977),
                new Book(14,"The Fellowship of the Ring", "J.R.R. Tolkien", 1954),
                new Book(15,"The Two Towers", "J.R.R. Tolkien", 1954),
            }
        );
        
        modelBuilder.Entity<Company>().HasData(
            new List<Company>()
            {
                new Company(1, "Google"),
                new Company(2, "Apple"),
                new Company(3, "Amazon"),
                new Company(4, "Facebook"),
            });

        modelBuilder.Entity<User>().HasData(
            new List<User>()
            {
                new User(1, "John Doe", 1),
                new User(2, "Jane Doe", 2),
                new User(3, "John Smith", 2),
                new User(4, "Jane Smith", 3),
                new User(5, "John Appleseed", 3),
            }
        );
        
        base.OnModelCreating(modelBuilder);

    }
}