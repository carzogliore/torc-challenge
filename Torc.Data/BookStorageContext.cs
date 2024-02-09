using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Torc.Business;

namespace Torc.Data;

public class BookStorageContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    
    public BookStorageContext(DbContextOptions<BookStorageContext> options) : base(options)
    {
    }
    
    
}