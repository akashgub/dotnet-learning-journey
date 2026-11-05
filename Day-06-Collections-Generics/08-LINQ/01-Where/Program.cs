List<int> numbers = new List<int>
{
    10, 15, 20, 25, 30, 35, 40, 45, 50
};

// LINQ Where() - Even Numbers
var evenNumbers = numbers.Where(number => number % 2 == 0);

Console.WriteLine("=== Even Numbers ===");

foreach (int number in evenNumbers)
{
    Console.WriteLine(number);
}

// LINQ Where() - Odd Numbers
var oddNumbers = numbers.Where(number => number % 2 != 0);

Console.WriteLine("\n=== Odd Numbers ===");

foreach (int number in oddNumbers)
{
    Console.WriteLine(number);
}
var filteredNumbers = numbers.Where(number => number > 30);

Console.WriteLine("\n=== Numbers Greater Than 30 ===");

foreach (int number in filteredNumbers)
{
    Console.WriteLine(number);
}
