
class Employee
{
    public string Name { get; set; }

    public double? Salary { get; set; }

    public double? Bonus { get; set; }

    public Employee(string name, double? salary, double? bonus)
    {
        Name = name;
        Salary = salary;
        Bonus = bonus;
    }

    public double CalculateTotalSalary()
    {
        double actualSalary = Salary ?? 0;
        double actualBonus = Bonus ?? 0;

        return actualSalary + actualBonus;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Employee: {Name}");
        Console.WriteLine($"Salary: {Salary ?? 0}");
        Console.WriteLine($"Bonus: {Bonus ?? 0}");
        Console.WriteLine($"Total Salary: {CalculateTotalSalary()}");
        Console.WriteLine($"Salary Available: {Salary.HasValue}");
    }
}

class Program
{
    static void Main()
    {
        Employee employee = new Employee("Akash", 30000, null);

        employee.ShowInfo();
    }
}