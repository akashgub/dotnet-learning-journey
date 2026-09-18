
interface IVehicle
{
    void Start();
}

class Car : IVehicle
{
    public void Start()
    {
        Console.WriteLine("Car is starting.");
    }
}

class Bike : IVehicle
{
    public void Start()
    {
        Console.WriteLine("Bike is starting.");
    }
}

class Program
{
    static void Main()
    {
        IVehicle car = new Car();
        car.Start();

        IVehicle bike = new Bike();
        bike.Start();
    }
}