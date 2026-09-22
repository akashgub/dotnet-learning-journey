abstract class Employee
{
    public int Id{get; set;}
    public string Name{get; set;}

    public Employee(int id, string name)
    {
        Id = id;
        Name = name;
    }
    
    public abstract void Work();
    public void DisplayInfo()
    {
        Console.WriteLine($"Id: {Id}, Name: {Name}");
    }
}