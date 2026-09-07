string studentName = "Akash";
int marks = 85;
int choice;

do{
    Console.WriteLine();
    Console.WriteLine("=====Student Results System====");
    Console.WriteLine("1. Show Student Information");
    Console.WriteLine("2. Show Grade");
    Console.WriteLine("3. Show Numbers 1-10");
    Console.WriteLine("4. Exit");
    Console.WriteLine("-----------------");

    Console.Write("Enter your choice: ");
    choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.WriteLine($"Student Name: {studentName}");
            Console.WriteLine($"Marks: {marks}");
            break;
        case 2:
            if (marks >= 90){
                Console.WriteLine("Grade: A+");
            }
            else if (marks >= 80){
                Console.WriteLine("Grade: A");
            }
            else if (marks >= 70){
                Console.WriteLine("Grade: B");
            }
            else if (marks >= 60){
                Console.WriteLine("Grade: C");
            }
            else if (marks >= 40){
                Console.WriteLine("Grade: D");
            }
            else{
                Console.WriteLine("Grade: F");
            }
            break;
        case 3:
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            break;
        case 4:
            Console.WriteLine();
            Console.WriteLine("Goodbye!");
            break;

        default:
            Console.WriteLine();
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }

}while (choice != 4);