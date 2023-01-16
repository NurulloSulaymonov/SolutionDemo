using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class BookService:GenericCrud<Book>
{
    public BookService(DataContext context) : base(context)
    {
    }
    
    

   
}
