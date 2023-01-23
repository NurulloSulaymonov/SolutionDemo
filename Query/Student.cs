public class Student 
{
    public int  StudentID  {get;set;}
    public string  StudentName  {get;set;}
    public int  Age  {get;set;}
    public int GroupId  {get;set;}
}

public class Group 
{
    public int  GroupId  {get;set;}
    public string  GroupName  {get;set;}
}

public class StudentGroupList 
{
    public string GroupName {get;set;} // c#
    public List<Student> Students {get;set;} // students of c# class

    public StudentGroupList(string groupName, List<Student> students)
    {
        GroupName = groupName;
        Students = students;
    }
    
}