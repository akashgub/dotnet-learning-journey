static void IncreaseMarks(ref int marks)
{
    marks += 10;
}

static void GetResult(int marks, out bool isPassed, out string grade)
{
    isPassed = marks >= 40;

    if (marks >= 80)
    {
        grade = "A+";
    }
    else if (marks >= 70)
    {
        grade = "A";
    }
    else if (marks >= 60)
    {
        grade = "B";
    }
    else if (marks >= 50)
    {
        grade = "C";
    }
    else
    {
        grade = "F";
    }
}

int marks = 70;

Console.WriteLine($"Before: {marks}");

IncreaseMarks(ref marks);

Console.WriteLine($"After: {marks}");

GetResult(marks, out bool isPassed, out string grade);

Console.WriteLine($"Passed: {isPassed}");
Console.WriteLine($"Grade: {grade}");