int[] marks = { 85, 72, 90, 68, 95 };

Console.WriteLine("===== Student Marks =====");

// 1. Print all marks using for loop
for (int i = 0; i < marks.Length; i++)
{
    Console.WriteLine($"Index {i}: {marks[i]}");
}

// 2. Access specific elements
Console.WriteLine("\n===== Access Elements =====");

Console.WriteLine($"First Mark: {marks[0]}");
Console.WriteLine($"Third Mark: {marks[2]}");
Console.WriteLine($"Last Mark: {marks[marks.Length - 1]}");

// 3. Update an element
marks[1] = 80;

Console.WriteLine("\n===== After Update =====");

for (int i = 0; i < marks.Length; i++)
{
    Console.WriteLine(marks[i]);
}

// 4. Calculate Sum
int sum = 0;

for (int i = 0; i < marks.Length; i++)
{
    sum += marks[i];
}

Console.WriteLine($"\nTotal Marks: {sum}");

// 5. Calculate Average
double average = (double)sum / marks.Length;

Console.WriteLine($"Average: {average}");

// 6. Find Maximum
int max = marks[0];

for (int i = 1; i < marks.Length; i++)
{
    if (marks[i] > max)
    {
        max = marks[i];
    }
}

Console.WriteLine($"Maximum: {max}");

// 7. Find Minimum
int min = marks[0];

for (int i = 1; i < marks.Length; i++)
{
    if (marks[i] < min)
    {
        min = marks[i];
    }
}

Console.WriteLine($"Minimum: {min}");

// 8. Search for a mark
int searchMark = 90;
bool found = false;

for (int i = 0; i < marks.Length; i++)
{
    if (marks[i] == searchMark)
    {
        found = true;
        break;
    }
}

Console.WriteLine($"\nIs {searchMark} found? {found}");

// 9. Count marks greater than or equal to 80
int count = 0;

for (int i = 0; i < marks.Length; i++)
{
    if (marks[i] >= 80)
    {
        count++;
    }
}

Console.WriteLine($"Marks >= 80: {count}");

// 10. foreach loop
Console.WriteLine("\n===== Using foreach =====");

foreach (int mark in marks)
{
    Console.WriteLine(mark);
}