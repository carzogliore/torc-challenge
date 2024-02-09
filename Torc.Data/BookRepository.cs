using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Torc.Business;
using Torc.Common;

namespace Torc.Data;

public class BookRepository : IRepository<Book>
{
    private readonly BookStorageContext _context;
    
    public BookRepository(BookStorageContext context)
    {
        this._context = context;
    }

    public async Task<IReadOnlyCollection<Book>> GetAllAsync(Expression<Func<Book, bool>> filter)
    {
        return await _context.Books.Where(filter).ToListAsync();
    }
}