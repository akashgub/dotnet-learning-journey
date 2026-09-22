# Employee Management System

A simple C# console-based Employee Management System built to practice and demonstrate the core concepts of Object-Oriented Programming (OOP).

## 📌 Project Overview

This project demonstrates how different OOP concepts can work together in a real-world style application.

The system contains different types of employees, such as:

* Developer
* Manager

Each employee has common information such as ID and Name, while different employee types have their own implementations of the `Work()` method.

The project also uses an interface to define common employee actions.

## 🧠 OOP Concepts Used

### 1. Class & Object

Classes are used to define employees and their behaviors.

Objects are created from the `Developer` and `Manager` classes.

### 2. Constructor

Constructors are used to initialize employee information such as:

* ID
* Name
* Programming Language
* Team Size

### 3. Encapsulation

Properties are used to control access to employee data.

```csharp
public int Id { get; set; }
public string Name { get; set; }
```

### 4. Inheritance

`Developer` and `Manager` inherit from the `Employee` base class.

```csharp
class Developer : Employee
```

```csharp
class Manager : Employee
```

### 5. Abstraction

`Employee` is an abstract class that defines common employee behavior.

```csharp
public abstract void Work();
```

The child classes provide their own implementation.

### 6. Polymorphism

The `Work()` method is overridden by different employee types.

```csharp
public override void Work()
```

A parent class reference can also point to different child class objects.

```csharp
Employee employee1 = new Developer(101, "Akash", "C#");
Employee employee2 = new Manager(102, "Rahim", 5);
```

This demonstrates runtime polymorphism.

### 7. Interface

The `IEmployeeActions` interface defines common actions that employees must implement.

```csharp
interface IEmployeeActions
{
    void AttendMeeting();
    void SubmitReport();
}
```

Both `Developer` and `Manager` implement this interface.

## 📁 Project Structure

```text
EmployeeManagement/
│
├── EmployeeManagement.csproj
├── Program.cs
├── README.md
│
├── Models/
│   ├── Employee.cs
│   ├── Developer.cs
│   └── Manager.cs
│
└── Interfaces/
    └── IEmployeeActions.cs
```

## 🛠️ Technologies Used

* C#
* .NET
* Object-Oriented Programming
* Console Application

## ▶️ How to Run

Clone or download the project and navigate to the project directory.

Run:

```bash
dotnet run
```

## 📤 Sample Output

```text
ID: 101, Name: Akash
Akash is developing software using C#.

ID: 102, Name: Rahim
Rahim is managing a team of 5 people.
```

## 📚 What I Learned

Through this project, I practiced:

* Creating classes and objects
* Using constructors
* Encapsulation with properties
* Class inheritance
* Abstract classes and methods
* Method overriding
* Runtime polymorphism
* Creating and implementing interfaces
* Organizing a C# project into folders
* Running a .NET console application

## 🎯 Learning Goal

This project was created as part of my C#/.NET learning journey to build a strong understanding of Object-Oriented Programming concepts before moving into more advanced .NET topics.
