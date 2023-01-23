namespace Domain.Entities;

public class TimeTable
{
    public int id { get; set; }
    public DayOfWeek DayOfWeek { get; set; }
    public DateTime Date { get; set; }
    public string StartTime { get; set; } // 12:00
    public string EndTime { get; set; }
    public List<SubjectTimetable> SubjectTimetables { get; set; }
    
}