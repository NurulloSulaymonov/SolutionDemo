namespace Domain.Entities;

public class Teacher:Person
{
    public List<Attendance> Attendances { get; set; }
    public List<Classroom> Classrooms { get; set; }

}