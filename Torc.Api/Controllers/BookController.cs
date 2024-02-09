using Microsoft.AspNetCore.Mvc;
using Torc.Api.Dtos;
using Torc.Business;

namespace Torc.Api.Controllers;

[ApiController]
[Route("books")]
public class BookController : ControllerBase
{
    private readonly IBookService _bookService;
    
    public BookController(IBookService bookService)
    {
        _bookService = bookService;
    }
    
    [Route("get-books")]
    [HttpGet]
    public async Task<ActionResult<IEnumerable<BookDto>>> GetBooks([FromQuery] FilterBookDto bookFilterDto)
    {
        var filterBook = new FilterBook()
        {
            Author = bookFilterDto.Author,
            Category = bookFilterDto.Category,
            ISBN = bookFilterDto.ISBN,
            Publisher = bookFilterDto.Publisher,
            Title = bookFilterDto.Title,
            Type = bookFilterDto.Type
        };

        var books = (await _bookService.GetBooks(filterBook))
            .Select(b => b.AsDto())
            .ToList();
        
        return Ok(books);
    }
}