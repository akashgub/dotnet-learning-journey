int choice = 3;

do
{
    Console.WriteLine("===== Menu =====");
    Console.WriteLine("1. View Profile");
    Console.WriteLine("2. View Products");
    Console.WriteLine("3. Exit");

    switch (choice)
    {
        case 1:
            Console.WriteLine("Profile selected");
            break;

        case 2:
            Console.WriteLine("Products selected");
            break;

        case 3:
            Console.WriteLine("Goodbye!");
            break;

        default:
            Console.WriteLine("Invalid choice.");
            break;
    }

} while (choice != 3);