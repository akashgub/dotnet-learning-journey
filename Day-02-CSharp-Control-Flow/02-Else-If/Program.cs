string studentName = "Akash";
int marks = 85;


Console.WriteLine("Student Results");
Console.WriteLine("----------------");
Console.WriteLine($"Student Name: {studentName}");
Console.WriteLine($"Marks: {marks}");

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
