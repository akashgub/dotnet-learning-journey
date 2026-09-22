Employee employee1 = new Developer(
    101,
    "Akash",
    "C#"
);

Employee employee2 = new Manager(
    102,
    "Rahim",
    5
);

employee1.DisplayInfo();
employee1.Work();

Console.WriteLine();

employee2.DisplayInfo();
employee2.Work(); 