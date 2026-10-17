string[] products =
{
    "C#",
    "Python",
    "JavaScript",
    "C++",
    "Go",
    "Ruby"
};

for(int i = 0; i < products.Length; i++)
{
    Console.WriteLine($"Index: {i}, Language: {products[i]}");
}

foreach(string product in products)
{
    Console.WriteLine($"Language: {product}");
}

Array.Sort(products);

Console.WriteLine("=== Sorted Products ===");

foreach (string product in products)
{
    Console.WriteLine($"Language: {product}");
}

int index = Array.IndexOf(products, "C#");

Console.WriteLine($"C# Index: {index}"); 

bool exists = Array.Exists(
    products,
    product => product == "Python"
);

Console.WriteLine($"Python Exists: {exists}");
