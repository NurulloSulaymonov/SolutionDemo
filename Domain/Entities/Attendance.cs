using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class Attendance
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public DateTime Date { get; set; }
    public AttendanceType AttendanceType { get; set; }
    public Status Status { get; set; }
    [ForeignKey("UserId")]
    public Student Student { get; set; }
     [ForeignKey("UserId")]
    public Teacher Teacher { get; set; }
}

public enum Status
{
    Present,
    Absent,
    Leave
}

public enum AttendanceType
{
    Student,
    Teacher
}



