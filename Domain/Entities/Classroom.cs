namespace Domain.Entities;

public class Classroom
{
    public int Id { get; set; }
    public string  Section { get; set; }
    public int Grade { get; set; }
    
    public List<SubjectTimetable> SubjectTimetables { get; set; }

}

public class SubjectTimetable
{
    public int TimetableId { get; set; }
    public TimeTable TimeTable { get; set; }
    
    public int ClassroomId { get; set; }
    public Classroom Classroom { get; set; }
    
    public int SubjectId { get; set; }
    public Subject Subject { get; set; }
}