namespace Domain.Entities;

public class Issue
{
    public int Id { get; set; }
    public string Details { get; set; }
    public Type Type { get; set; }
    public bool IsResolved { get; set; }
    public int StudentId { get; set; }
    public Student Student { get; set; }
}

public enum Type
{
    Late,
    Absent,
    BadWords,
    Conflict
}
