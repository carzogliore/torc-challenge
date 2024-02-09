namespace Torc.Business;

public interface IBookService
{
    Task<IReadOnlyCollection<Book>> GetBooks(FilterBook filterBookDto);
}