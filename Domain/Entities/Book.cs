using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Book
{
    [Key]
    public int Id { get; set; }
    [Required,MaxLength(50)] // required - not null
    public string Title { get; set; }
    public int NumberOfPages { get; set; }
    [MaxLength(50)]
    public string Author { get; set; }

    public Book()
    {
        
    }

    public Book(int id,string title, string author, int numberOfPages)
    {
        Id = id;
        Title = title;
        Author = author;
        NumberOfPages = numberOfPages;
    }
    
    
}