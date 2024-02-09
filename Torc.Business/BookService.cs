using Torc.Common;

namespace Torc.Business;

public class BookService : IBookService
{
    private readonly IRepository<Book> _bookRepository;
    
    public BookService(IRepository<Book> bookRepository)
    {
        _bookRepository = bookRepository;
    }
    
    public async Task<IReadOnlyCollection<Book>> GetBooks(FilterBook filterBookDto)
    {
        return await _bookRepository.GetAllAsync(b => (string.IsNullOrEmpty(filterBookDto.Type) || b.Type == filterBookDto.Type) &&
                                                      (string.IsNullOrEmpty(filterBookDto.Title) ||  b.Title.Contains(filterBookDto.Title)) && 
                                                       (string.IsNullOrEmpty(filterBookDto.Publisher) || b.Publisher.Contains(filterBookDto.Publisher)) && 
                                                        (string.IsNullOrEmpty(filterBookDto.Author) || b.FirstName.Contains(filterBookDto.Author)) &&
                                                         (string.IsNullOrEmpty(filterBookDto.Author) || b.LastName.Contains(filterBookDto.Author)) &&
                                                          (string.IsNullOrEmpty(filterBookDto.ISBN) || b.ISBN.Contains(filterBookDto.ISBN)) &&
                                                           (string.IsNullOrEmpty(filterBookDto.Category) ||  b.Category.Contains(filterBookDto.Category)));
    }
}