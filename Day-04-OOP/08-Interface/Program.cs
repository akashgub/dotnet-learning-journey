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
class Test
{
    public static void Main(string[] args)
    {
        Car car = new Car();
        car.Start();

        Bike bike = new Bike();
        bike.Start();
    }
}