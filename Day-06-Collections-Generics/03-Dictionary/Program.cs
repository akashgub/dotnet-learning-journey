
Dictionary<int, string> students = new()
{
    { 101, "Akash" },
    { 102, "Rahim" },
    { 103, "Karim" }
};

students.Add(105, "Nusrat");

Console.WriteLine($"Student 101: {students[101]}");

Console.WriteLine($"Has ID 105: {students.ContainsKey(105)}");

students.Remove(103);

Console.WriteLine($"Total Students: {students.Count}");

Console.WriteLine("=== Updated Student List ===");

foreach (KeyValuePair<int, string> student in students)
{
    Console.WriteLine($"ID: {student.Key} | Name: {student.Value}");
}
 