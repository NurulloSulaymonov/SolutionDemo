using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public abstract class Person
{
    public int Id { get; set; }
    public string Email { get; set; }
    [Required,MaxLength(50)]
    public string Password { get; set; }
    public Gender Gender { get; set; }
    [Required,MaxLength(50)]
    public string FirstName { get; set; }
    public DateTime BirthDate { get; set; }
    [Required,MaxLength(100)]
    public string Address { get; set; }
    [Required,MaxLength(20)]
    public string Phone { get; set; }
    public DateTime JoinDate { get; set; }
    
}