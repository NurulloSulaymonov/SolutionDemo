
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }
    
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Issue> Issues { get; set; }
    public DbSet<Attendance> Attendances { get; set; }
    public DbSet<Exam> Exams { get; set; }
    public DbSet<Result> Results { get; set; }
    public DbSet<Classroom> Classrooms { get; set; }
    public DbSet<ClassroomStudent> ClassroomStudents { get; set; }
    public DbSet<TimeTable> TimeTables { get; set; }
    public DbSet<SubjectTimetable> SubjectTimetables { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Result>().HasKey(x => new
        {
            x.ExamId, x.StudentId
        });
        
        modelBuilder.Entity<ClassroomStudent>().HasKey(x => new
        {
            x.StudentId, x.ClassroomId
        });
        
        modelBuilder.Entity<SubjectTimetable>().HasKey(x => new
        {
            x.ClassroomId, x.TimetableId,x.SubjectId
        });
        base.OnModelCreating(modelBuilder);
    }
}