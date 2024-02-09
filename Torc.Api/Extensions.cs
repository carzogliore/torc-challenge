using Torc.Api.Dtos;
using Torc.Business;

namespace Torc.Api;

public static class Extensions
{
    public static BookDto AsDto(this Book item)
    {
        return new BookDto(item.Id, item.Title, item.Publisher, $"{item.FirstName} {item.LastName}", item.Type, item.ISBN, item.Category, item.TotalCopies, item.CopiesInUse);
    }
}