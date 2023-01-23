using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Student:Person 
{
    
    [Required,MaxLength(50)]
    public string ParentName { get; set; }

    public List<Issue> Issues { get; set; }
    public List<Attendance> Attendances { get; set; }
    public List<Result> examResults { get; set; }
    public List<ClassroomStudent> ClassroomStudents { get; set; }
    
}

public enum Gender
{
Male,
Female
}