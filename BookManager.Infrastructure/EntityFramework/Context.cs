using BookManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookManager.Infrastructure.EntityFramework;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options) : base(options)
    {
            
    }
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Genre> Categories { get; set; }
}