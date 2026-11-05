List<string> students = new List<string>
{
    "Akash",
    "Rahim",
    "Nusrat",
    "Karim",
    "Sadia"
};

bool hasStudentNamedNusrat = students.Any(name => name == "Nusrat");

Console.WriteLine($"Is Nusrat Available: {hasStudentNamedNusrat}");

bool hasStudentNameStartsWithS = students.Any(name => name.StartsWith("S"));
Console.WriteLine($"Any Name Starts with S: {hasStudentNameStartsWithS}");

bool hasStudentNameStartsWithZ = students.Any(name => name.StartsWith("Z"));
Console.WriteLine($"Any Name Starts with Z: {hasStudentNameStartsWithZ}");
