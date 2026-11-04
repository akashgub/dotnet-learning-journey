List<Product> products = new List<Product>
{
    new Product { Id = 1, Name = "Mobile", Price = 25000 },
    new Product { Id = 2, Name = "Laptop", Price = 65000 },
    new Product { Id = 3, Name = "Mouse", Price = 800 },
    new Product { Id = 4, Name = "Monitor", Price = 12000 }
};
var productDetails = products.Select(product => new 
{ productName = product.Name, 
  productPrice = product.Price 
});

Console.WriteLine("=== Product Information ===");
foreach (var product in productDetails)
{
    Console.WriteLine($"{product.productName} - {product.productPrice}");
}
