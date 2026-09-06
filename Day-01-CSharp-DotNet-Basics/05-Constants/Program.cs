var Product = "Laptop";
var price = 50000m;
var Quantity = 2;
const decimal TaxRate = 0.05m;

var Subtotal = price * Quantity;
var Tax = Subtotal * TaxRate;
var Total = Subtotal + Tax;

Console.WriteLine("Invoice Information:");
Console.WriteLine("--------------------");
Console.WriteLine("Product: " + Product);
Console.WriteLine("Price: " + price);
Console.WriteLine("Quantity: " + Quantity);
Console.WriteLine("Subtotal: " + Subtotal);
Console.WriteLine("Tax: " + Tax);
Console.WriteLine("Total: " + Total);