List<int> numbers = new List<int>
{
    10, 20, 30, 40, 60, 70, 80, 90
};

int firstNumber = numbers.First(n => n > 50);

Console.WriteLine($"First number greater than 50: {firstNumber}");
