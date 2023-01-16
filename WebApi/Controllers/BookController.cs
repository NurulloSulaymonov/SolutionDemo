using Domain.Entities;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class BookController : ControllerBase
{
    private  BookService _bookService;
    public BookController(BookService bookService)
    {
        _bookService = bookService;
    }

    [HttpGet]
    public List<Book> Get()
    {
        return _bookService.Get();
    }
    
    [HttpGet("{id}")]
    public Book Get(int id) => _bookService.Get(id);
    
    [HttpPost]
    public void Post([FromBody] Book book) => _bookService.Add(book);
    
    [HttpPut]
    public void Put([FromBody] Book book) => _bookService.Update(book);
    
    [HttpDelete("{id}")]
    public void Delete(int id) => _bookService.Delete(id);


}