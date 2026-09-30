class Student
{
    public string Name{ get; set; }
    public int Age{ get; private set; }
    public double CGPA{ get; private set; }
    
    public void SetAge(int age)
    {
        if(age >= 18)
        {
            Age = age;
        }
        else
        {
            Console.WriteLine("Age must be at least 18.");
        }
    }
    public void SetCGPA(double cgpa)
    {
        if(cgpa >= 0 && cgpa <= 4)
        {
            CGPA = cgpa;
        }
        else
        {
            Console.WriteLine("CGPA must be between 0 and 4.");
        }
    }
}
class Program 
{
    static void Main()
    {
        Student student = new Student();

        student.Name = "Akash";
        student.SetAge(24);
        student.SetCGPA(3.30);

        Console.WriteLine($"Name: {student.Name}");
        Console.WriteLine($"Age: {student.Age}");
        Console.WriteLine($"CGPA: {student.CGPA}");
    }
}
