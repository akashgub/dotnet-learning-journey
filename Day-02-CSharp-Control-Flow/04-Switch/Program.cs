﻿int choice = 2;

Console.WriteLine("=====Menu=====");
Console.WriteLine("1. View Profile");
Console.WriteLine("2. View Products");
Console.WriteLine("3. View Orders");
Console.WriteLine("4. Logout");
Console.WriteLine("-----------------");

switch (choice)
{
    case 1:
        Console.WriteLine("Profile selected");
        break;
    case 2:
        Console.WriteLine("Product selected");
        break;
    case 3:
        Console.WriteLine("Order selected");
        break;
    case 4:
        Console.WriteLine("Logout selected");
        break;
    default:
        Console.WriteLine("Invalid choice.");
        break;
}