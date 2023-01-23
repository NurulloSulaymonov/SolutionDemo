namespace Domain.Entities;

public class Exam
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public string Name { get; set; }
    public ExamType ExamType { get; set; }
    
    public int SubjectId { get; set; }
    public Subject Subject { get; set; }
    public List<Result> Results { get; set; }
}

public  enum ExamType
{
    Oral,
    Written
}