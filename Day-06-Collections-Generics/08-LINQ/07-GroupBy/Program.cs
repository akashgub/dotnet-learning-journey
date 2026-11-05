List<Student> students = new List<Student>
{
    new Student { Name = "Akash", Department = "CSE" },
    new Student { Name = "Rahim", Department = "EEE" },
    new Student { Name = "Nusrat", Department = "CSE" },
    new Student { Name = "Karim", Department = "BBA" },
    new Student { Name = "Sadia", Department = "EEE" },
    new Student { Name = "Hasan", Department = "CSE" }
};

var groupedStudents = students.GroupBy(student => student.Department);

foreach (var group in groupedStudents)
{
    Console.WriteLine($"\n=== {group.Key} Department ===");

    Console.WriteLine($"Total Students: {group.Count()}");

    foreach (var student in group)
    {
        Console.WriteLine(student.Name);
    }
}