HashSet<string> students = new()
{
    "Akash",
    "Rahim",
    "Karim"
};

Console.WriteLine($"Initial Count: {students.Count}");

// Add a new name => Nusrat
students.Add("Nusrat");
Console.WriteLine($"After Adding Nusrat: {students.Count}");

// Try adding a duplicate => Akash
bool added = students.Add("Akash");
Console.WriteLine($"Was Akash Added Again? {added}");

// Check whether a name exists => Rahim
Console.WriteLine($"Contains Rahim: {students.Contains("Rahim")}");

// Remove a name => Karim
students.Remove("Karim");
Console.WriteLine($"After Removing Karim: {students.Count}");

Console.WriteLine("=== Final Students ===");

foreach (string student in students)
{
    Console.WriteLine(student);
} 
