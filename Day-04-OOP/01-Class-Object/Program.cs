class Student
{
    public string Name;
    public int Age;
    public string Department;
    public string University;

}
class Test
{
    static void Main(string[] args)
    {
        Student student1 = new Student();
        student1.Name = "Akash";
        student1.Age = 24;
        student1.Department = "CSE";
        student1.University = "Green University Of Bangladesh";
        Console.WriteLine("Name: " + student1.Name + ", Age: " + student1.Age + ", Department: " + student1.Department + ", University: " + student1.University);

        Student student2 = new Student();
        student2.Name = "Rahim";
        student2.Age = 23;
        student2.Department = "CSE";
        student2.University = "Green University Of Bangladesh";
        Console.WriteLine("Name: " + student2.Name + ", Age: " + student2.Age + ", Department: " + student2.Department + ", University: " + student2.University);

        Student student3 = new Student();
        student3.Name = "Karim";
        student3.Age = 25;
        student3.Department = "SWE";
        student3.University = "Green University Of Bangladesh";
        Console.WriteLine("Name: " + student3.Name + ", Age: " + student3.Age + ", Department: " + student3.Department + ", University: " + student3.University);
    }
}