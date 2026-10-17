
List<Product> products = new List<Product>
{
    new Product
    {
        Id = 1,
        Name = "Laptop",
        Price = 65000m,
        Description = "This is a high-end laptop with powerful performance and sleek design."
    },
    new Product
    {
        Id = 2,
        Name = "Mouse",
        Price = 800m,
        Description = "This is a wireless mouse with ergonomic design and precise tracking."
    },
    new Product
    {
        Id = 3,
        Name = "Keyboard",
        Price = 1500m,
        Description = "This is a mechanical keyboard with responsive switches and customizable backlighting."
    }
};

products.Add(new Product
{
    Id = 4,
    Name = "Monitor",
    Price = 12000m,
    Description = "This is a 24-inch monitor with Full HD resolution and vibrant colors."
});

Console.WriteLine("=== Product List ===");

foreach (Product product in products)
{
    Console.WriteLine(
        $"ID: {product.Id} | " +
        $"Name: {product.Name} | " +
        $"Price: {product.Price} | " +
        $"Description: {product.Description}"
    );
}

Console.WriteLine($"Total Products: {products.Count}");

