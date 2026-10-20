
Queue<string> customers = new Queue<string>();

// 1. Add customers to the queue
customers.Enqueue("Akash");
customers.Enqueue("Rahim");
customers.Enqueue("Karim");
customers.Enqueue("Nusrat");

Console.WriteLine("=== Bank Customer Queue ===");

// 2. Print total customers
Console.WriteLine($"Total Customers: {customers.Count}");

// 3. Check the first customer
Console.WriteLine($"Next Customer: {customers.Peek()}");

// 4. Serve the first customer
Console.WriteLine($"Serving Customer: {customers.Dequeue()}");

// 5. Add a new customer
customers.Enqueue("Sadia");

// 6. Print remaining customers
Console.WriteLine("\n=== Remaining Customers ===");

foreach (string customer in customers)
{
    Console.WriteLine(customer);
}

// 7. Print final count
Console.WriteLine($"Final Customer Count: {customers.Count}");
