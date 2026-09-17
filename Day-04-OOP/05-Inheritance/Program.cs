class Vehicle
{
    public string Brand;

    public void Start()
    {
        Console.WriteLine("Vehicle is starting.");
    }
}

class Car : Vehicle
{
    public void Drive()
    {
        Console.WriteLine("Car is driving.");
    }
}

class Test
{
    public static void Main(string[] args)
    {
        Car car = new Car();

        car.Brand = "Toyota";

        Console.WriteLine(car.Brand);
        car.Start();
        car.Drive();
    }
}