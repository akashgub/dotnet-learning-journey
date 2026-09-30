class Person
{
    public string Name = "Akash";
    private int Age = 24;
    protected string Country = "Bangladesh";
    public void ShowPrivateData()
    {
        Console.WriteLine($"Age: {Age}");
    }
}
class Student : Person
{
    public void ShowProtecteData()
    {
        Console.WriteLine($"Countyr: {Country}");
    }
}
internal class Program
{
    static void Main()
    {
        Person person = new Person();

        // public
        Console.WriteLine($"Name: {person.Name}");

        //private
        person.ShowPrivateData();

        Student student = new Student();

        //protected
        student.ShowProtecteData();
    }
}
