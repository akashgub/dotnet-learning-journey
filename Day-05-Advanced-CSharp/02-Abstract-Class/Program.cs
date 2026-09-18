
abstract class Vehicle
{
    public abstract void Start();

    public void Stop()
    {
        Console.WriteLine("Vehicle is stopping.");
    }
}

class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Car is starting.");
    }
}

class Bike : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Bike is starting.");
    }
}

class Program
{
    static void Main()
    {
        Vehicle car = new Car();
        car.Start();
        car.Stop();

        Console.WriteLine();

        Vehicle bike = new Bike();
        bike.Start();
        bike.Stop();
    }
}