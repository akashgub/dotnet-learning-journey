List<Product> products = new List<Product>
{
    new Product { Name = "Laptop", Price = 65000 },
    new Product { Name = "Mouse", Price = 800 },
    new Product { Name = "Keyboard", Price = 1500 },
    new Product { Name = "Monitor", Price = 12000 }
};

// A to Z Order
var AToZ = products.OrderBy(product => product.Name);

Console.WriteLine("\n=== Products: A to Z ===");

foreach (var product in AToZ)
{
    Console.WriteLine($"{product.Name} - {product.Price}");
}

// Z to A Order
var ZToA = products.OrderByDescending(product => product.Name);

Console.WriteLine("\n=== Products: Z to A ===");

foreach (var product in ZToA)
{
    Console.WriteLine($"{product.Name} - {product.Price}");
}

