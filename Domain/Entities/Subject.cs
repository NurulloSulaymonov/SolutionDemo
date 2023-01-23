using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Subject
{
    public int Id { get; set; }
    [Required,MaxLength(100)]
    public string Name { get; set; }
    public int Grade { get; set; }
    [Required,MaxLength(100)]
    public string Description { get; set; }
    
    public List<SubjectTimetable> SubjectTimetables { get; set; }

    public List<Exam> Exams { get; set; }
    
}