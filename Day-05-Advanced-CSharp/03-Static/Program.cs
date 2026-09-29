/*
class Calculator 
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Multiply(int a, int b){
        return a * b;
    }

}
class Program 
{
    static void Main()
    {
        int sum = Calculator.Add(10, 20);
        int multiplication = Calculator.Multiply(5, 4);

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Multiplication: {multiplication}");
    }
}
*/

class StudentResult
{
    public static int CalculateTotal(int mark1, int mark2, int mark3)
    {
        return mark1 + mark2 + mark3;
    }

    public static double CalculateAverage(int total)
    {
        return total / 3.0;
    }
}
class Program 
{
    static void Main(){
        int total = StudentResult.CalculateTotal(80, 80, 80);
        double average = StudentResult.CalculateAverage(total);

        Console.WriteLine($"Total: {total}");
        Console.WriteLine($"Average: {average}");
    }
}