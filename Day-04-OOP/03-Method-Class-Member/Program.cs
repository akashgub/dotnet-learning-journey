class Person
{
    public string name;
    public int age;

    public void SetValue(string n, int a){
        name = n;
        age = a;
    }

    public void DisplayInfo(){
        Console.WriteLine($"Name: {name}, Age: {age}\n"); 

}

}

class Test 
{
    public static void Main(string[] args)
    {
        Person p1 = new Person();
        p1.SetValue("Akash", 25);
        p1.DisplayInfo();

        Person p2 = new Person();
        p2.SetValue("Karim", 30);
        p2.DisplayInfo();
        
    }
}