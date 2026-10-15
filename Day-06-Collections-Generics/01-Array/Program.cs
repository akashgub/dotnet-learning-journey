string[] products =
{
    "Laptop",
    "Smartphone",
    "Tablet",
    "Headphones",
    "Smartwatch"
};

Array.Sort(products);

Console.WriteLine("=== Sorted Products ===");

foreach (string product in products)
{
    Console.WriteLine(product);
}

int index = Array.IndexOf(products, "Smartphone");

Console.WriteLine($"Smartphone Index: {index}"); 

bool exists = Array.Exists(
    products,
    product => product == "Mouse"
);

Console.WriteLine($"Mouse Exists: {exists}");