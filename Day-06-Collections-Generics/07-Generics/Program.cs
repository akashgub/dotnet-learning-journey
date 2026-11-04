
Repository<string> studentRepository = new Repository<string>();

studentRepository.Add("Akash");
studentRepository.Add("Rahim");
studentRepository.Add("Nusrat");

Console.WriteLine("=== Students ===");

studentRepository.DisplayAll();

Console.WriteLine($"Total Students: {studentRepository.Count()}");

Repository<int> numberRepository = new Repository<int>();

numberRepository.Add(100);
numberRepository.Add(200);
numberRepository.Add(300);

Console.WriteLine("\n=== Numbers ===");

numberRepository.DisplayAll();

Console.WriteLine($"Total Numbers: {numberRepository.Count()}");

Console.WriteLine("\n===Storage====");

Storage<string> nameStorage = new Storage<string>();
nameStorage.SetData("Akash");

Console.WriteLine($"Stored Name: {nameStorage.GetData()}");

Storage<int> ageStorage = new Storage<int>();
ageStorage.SetData(24);

Console.WriteLine($"Stored Age: {ageStorage.GetData()}");

Storage<double> priceStorage = new Storage<double>();
priceStorage.SetData(99.50);

priceStorage.DisplayData();
