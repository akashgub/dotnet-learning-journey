class Person
{
    public string name;
    public int age;

}

class Test 
{
    public static void Main(string[] args)
    {
        Person p1 = new Person();
        p1.name = "Akash";
        p1.age = 24;
        Console.WriteLine($"Name: {p1.name}, Age: {p1.age}\n"); 

        Person p2 = new Person();
        p2.name = "Karim";
        p2.age = 30;
        Console.WriteLine($"Name: {p2.name}, Age: {p2.age}\n"); 

        
    }
}