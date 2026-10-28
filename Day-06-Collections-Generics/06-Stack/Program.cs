Stack<string> website = new Stack<string>();

// Add websites to the stack
website.Push("google.com");
website.Push("youtube.com");
website.Push("github.com");
website.Push("stackoverflow.com");

Console.WriteLine("=== Website Stack ===");

Console.WriteLine($"Total Websites: {website.Count}");

// See the top website
Console.WriteLine($"Top Website: {website.Peek()}");

// Remove the top website
Console.WriteLine($"Removing Website: {website.Pop()}");

Console.WriteLine($"New Top Website: {website.Peek()}");

Console.WriteLine($"Remaining Websites: {website.Count}");

Console.WriteLine("=== Remaining Websites ===");

foreach (string site in website)
{
    Console.WriteLine(site);
}

