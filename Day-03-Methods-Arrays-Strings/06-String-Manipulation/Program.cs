string name =" Akash Hossain ";
string email = "akash@gmail.com";

Console.WriteLine("\n===== String Manipulation =====");

// 1. Original String
Console.WriteLine($"Original: '{name}'");

// 2. Trim
string trimmedName = name.Trim();

Console.WriteLine($"Trimmed: '{trimmedName}'");

// 3. Length
Console.WriteLine($"Length: {trimmedName.Length}");

// 4. Uppercase
Console.WriteLine($"Uppercase: {trimmedName.ToUpper()}");

// 5. Lowercase
Console.WriteLine($"Lowercase: {trimmedName.ToLower()}");

// 6. Index 
Console.WriteLine($"First Character: {trimmedName[0]}");

// 7. Contains
Console.WriteLine($"Contains 'Akash': {trimmedName.Contains("Akash")}");

// 8. StartsWith 
Console.WriteLine($"Starts With 'Akash': {trimmedName.StartsWith("Akash")}");

// 9. EndsWith
Console.WriteLine($"Ends With 'Hossain': {trimmedName.EndsWith("Hossain")}");

// 10. Replace
string replacedName = trimmedName.Replace("Akash", "John");
Console.WriteLine($"Replaced: '{replacedName}'");

// 11. Substring
string substringName = trimmedName.Substring(0, 5);
Console.WriteLine($"Substring: '{substringName}'");

// 12. Email Validation
Console.WriteLine($"Valid Email: {email.Contains("@") && email.Contains(".")}");

// 13. Split
string data = "Akash,Hossain,CSE";
string[] parts = data.Split(',');

Console.WriteLine("=====Split Parts====");

foreach(string part in parts)
{
    Console.WriteLine(part);
}