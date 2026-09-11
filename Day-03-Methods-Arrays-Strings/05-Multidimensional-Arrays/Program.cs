int[,] marks =
{
    { 80, 75, 90 },
    { 85, 82, 88 },
    { 70, 78, 95 }
};

Console.WriteLine("===== Student Marks =====");

int max = marks[0, 0];

for (int row = 0; row < marks.GetLength(0); row++)
{
    int total = 0;

    Console.Write($"Student {row + 1}: ");

    for (int column = 0; column < marks.GetLength(1); column++)
    {
        int mark = marks[row, column];

        Console.Write(mark + " ");

        total += mark;

        if (mark > max)
        {
            max = mark;
        }
    }

    double average = (double)total / marks.GetLength(1);

    Console.WriteLine($"| Total: {total} | Average: {average:F2}");
}

Console.WriteLine($"\nMaximum Mark: {max}");