class Employee
{
    public string Name;
    public int Age;
    public string Position;
    public int Salary;


    public Employee(string name, int age, string position, int salary){
        Name = name;
        Age = age;
        Position = position;
        Salary = salary;
    }

    public void DisplayInfo(){
        Console.WriteLine($"Name: {Name}, Age: {Age}, Position: {Position}, Salary: {Salary}"); 

}

}

class Test 
{
    public static void Main(string[] args)
    {
        Employee E1 = new Employee("Akash", 24, "Junior Software Engineer", 25000);
        E1.DisplayInfo();

        Employee E2 = new Employee("Rahim", 25, "Backend Developer", 30000);
        E2.DisplayInfo();

        Employee E3 = new Employee("Karim", 26, "Software Engineer", 40000);
        E3.DisplayInfo();
        
    }
}