class Shape
{
    public virtual double GetArea()
    {
        return 0;
    }
}

class Rectangle : Shape
{
    public double Width;
    public double Height;

    public override double GetArea()
    {
        return Width * Height;
    }
}

class Circle : Shape
{
    public double Radius;

    public override double GetArea()
    {
        return 3.14 * Radius * Radius;
    }
}

class Test
{
    public static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle();
        rectangle.Width = 10;
        rectangle.Height = 5;

        Circle circle = new Circle();
        circle.Radius = 5;

        Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");
        Console.WriteLine($"Circle Area: {circle.GetArea()}");
    }
} 