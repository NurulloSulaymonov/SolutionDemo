using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class Result
{
    
    public int Mark { get; set; }
    public int ExamId { get; set; }
    public Exam Exam { get; set; }
    
    public int StudentId { get; set; }
    public Student Student { get; set; }
}