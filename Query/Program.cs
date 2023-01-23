
var studentList = new List<Student>() 
{ 
    new Student() { StudentID = 1, StudentName = "Suhaib", Age = 19, GroupId = 1 } ,
    new Student() { StudentID = 2, StudentName = "Jahonzeb",  Age = 19, GroupId = 1 } ,
    new Student() { StudentID = 3, StudentName = "Sunatullo",  Age = 17, GroupId = 2 } ,
    new Student() { StudentID = 4, StudentName = "Ikromi" , Age = 17, GroupId = 2 } ,
    new Student() { StudentID = 5, StudentName = "Muhammadjon" , Age = 17, GroupId = 3 },
    new Student() { StudentID = 5, StudentName = "Khayriddin" , Age = 18, GroupId = 3 },
    new Student() { StudentID = 5, StudentName = "Khayriddin" , Age = 18, GroupId = 2 } 
};

var groupList = new List<Group>() 
{ 
    new Group(){ GroupId = 1, GroupName="Chemistry"},
    new Group(){ GroupId = 2, GroupName="Biology"},
    new Group(){ GroupId = 3, GroupName="Math"}
};

// select 
var res1 = studentList.Select(x=>x.Age);

//distinct
var res2 = studentList.Select(x=>x.Age).Distinct();

//where
var res3 = studentList.Where(x=>x.Age>18);

//orderby
var res4 = studentList.OrderBy(x=>x.Age);

//orderby descending
var res5 = studentList.OrderByDescending(x=>x.Age);

//orderby thenby
var res6 = studentList.OrderBy(x=>x.GroupId).ThenByDescending(x=>x.Age);


//join
var res7 = studentList
    .Join(groupList,
        s => s.GroupId,
        g => g.GroupId, 
        (s, g) => 
            new
            {
                s.StudentName, 
                g.GroupName
            });

//groupby
var res8 = studentList.GroupBy(x=>x.GroupId).ToList();

res8.ForEach(x =>
{
    Console.WriteLine(x.Key); 
    foreach (var student in x)
    {
        Console.WriteLine(student.StudentName);
    }
});

    Console.Write(string.Join(",", res1));
   

