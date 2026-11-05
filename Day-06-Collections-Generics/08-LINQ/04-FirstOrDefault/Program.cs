List<int> numbers = new List<int>
{
    10, 20, 30, 40, 50, 60, 70
};

// Find the first number greater than 50
int? firstNumber = numbers.FirstOrDefault(n => n > 50);

if (firstNumber != 0)
{
    Console.WriteLine($"Number Found: {firstNumber}");
}
else
{
    Console.WriteLine("Number Not Found");
}
