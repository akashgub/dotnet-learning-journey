# Day 4 — Object-Oriented Programming (OOP)

## 📚 Overview

On Day 4 of my C#/.NET learning journey, I focused on **Object-Oriented Programming (OOP)** and learned how to design programs using classes, objects, inheritance, abstraction, polymorphism, encapsulation, and interfaces.

I also built an **Employee Management System** mini project to apply the OOP concepts in a practical scenario.

---

## 🎯 Learning Objectives

* Understand the fundamentals of Object-Oriented Programming
* Create and use classes and objects
* Understand constructors
* Define methods and class members
* Apply encapsulation
* Implement inheritance
* Understand compile-time and runtime polymorphism
* Implement abstraction using abstract classes
* Understand and implement interfaces
* Understand the four pillars of OOP
* Combine multiple OOP concepts in a practical project

---

## 🧠 Topics Covered

### 1. Class & Object

Learned how to create classes and instantiate objects.

**Key concepts:**

* Class
* Object
* Fields
* Properties
* Object creation using `new`

---

### 2. Constructor

Learned how constructors initialize objects when they are created.

**Covered:**

* Parameterless constructor
* Parameterized constructor
* Constructor overloading
* Passing values through constructors

---

### 3. Methods & Class Members

Learned how methods define the behavior of a class.

**Covered:**

* Instance methods
* Class members
* Passing parameters
* Returning values
* Calling methods through objects

---

### 4. Encapsulation

Learned how to protect data and control access to class members.

**Covered:**

* `private`
* `public`
* Getter and setter methods
* Properties
* Controlled access to data
* Basic validation

---

### 5. Inheritance

Learned how a child class can reuse functionality from a parent class.

Example:

```csharp
class Car : Vehicle
{
}
```

**Key concepts:**

* Base class
* Derived class
* Code reuse
* `:`
* `base`
* `protected`

---

### 6. Polymorphism

Learned how the same method or interface can have different behaviors.

**Covered:**

* Method overloading
* Method overriding
* `virtual`
* `override`
* Runtime polymorphism

Example:

```csharp
Employee employee = new Developer();
employee.Work();
```

The same `Work()` method can behave differently depending on the actual object.

---

### 7. Abstraction

Learned how to hide unnecessary implementation details and expose only essential functionality.

Implemented using:

* `abstract class`
* `abstract method`

Example:

```csharp
abstract class Employee
{
    public abstract void Work();
}
```

The parent class defines **what** should happen, while the child class defines **how** it happens.

---

### 8. Interface

Learned that an interface acts as a contract that defines what a class must implement.

Example:

```csharp
interface IEmployeeActions
{
    void AttendMeeting();
    void SubmitReport();
}
```

Classes implementing the interface must provide implementations for these methods.

---

## 🏛️ Four Pillars of OOP

| Pillar        | Purpose                     |
| ------------- | --------------------------- |
| Encapsulation | Protect and control data    |
| Inheritance   | Reuse existing code         |
| Polymorphism  | Allow different behaviors   |
| Abstraction   | Hide implementation details |

### Quick Memory

```text
Encapsulation → Protect
Inheritance   → Reuse
Polymorphism  → Many Forms
Abstraction   → Hide
```

---

# 🚀 Mini Project — Employee Management System

To apply the concepts learned throughout Day 4, I built a small **Employee Management System** using C# and .NET.

## 📌 Project Features

The project contains different types of employees:

* Developer
* Manager

Each employee has common information such as:

* Employee ID
* Employee Name

Different employee types implement their own `Work()` behavior.

The project also uses an interface for common employee actions.

---

## 🏗️ Project Structure

```text
09-OOP-Mini-Project/
└── EmployeeManagement/
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

---

## 🧩 OOP Concepts Used in the Mini Project

### Abstraction

`Employee` is an abstract base class.

```csharp
abstract class Employee
{
    public abstract void Work();
}
```

### Inheritance

```csharp
class Developer : Employee
{
}
```

```csharp
class Manager : Employee
{
}
```

### Polymorphism

Both child classes override the `Work()` method:

```csharp
public override void Work()
{
    // Developer behavior
}
```

and:

```csharp
public override void Work()
{
    // Manager behavior
}
```

Runtime polymorphism is demonstrated using:

```csharp
Employee employee1 = new Developer(101, "Akash", "C#");
Employee employee2 = new Manager(102, "Rahim", 5);
```

### Interface

Both `Developer` and `Manager` implement:

```csharp
IEmployeeActions
```

which requires:

```csharp
AttendMeeting();
SubmitReport();
```

---

## ▶️ Running the Project

Navigate to the project directory:

```bash
cd Day-04-OOP/09-OOP-Mini-Project/EmployeeManagement
```

Run the application:

```bash
dotnet run
```

### Sample Output

```text
ID: 101, Name: Akash
Akash is developing software using C#.
Akash is attending a meeting.
Akash submitted the development report.

ID: 102, Name: Rahim
Rahim is managing a team of 5 people.
Rahim is attending a management meeting.
Rahim submitted the management report.
```

---

## 🛠️ Technologies Used

* C#
* .NET
* .NET Console Application
* Object-Oriented Programming

---

## 📖 Key Takeaways

After completing Day 4, I gained practical understanding of:

* How classes and objects work
* How constructors initialize objects
* How methods define class behavior
* How encapsulation protects data
* How inheritance enables code reuse
* How polymorphism allows different implementations
* How abstraction hides implementation details
* How interfaces define contracts
* How multiple OOP concepts work together in a real project

---

## ✅ Day 4 Completion Checklist

* [x] Class & Object
* [x] Constructor
* [x] Methods & Class Members
* [x] Encapsulation
* [x] Inheritance
* [x] Polymorphism
* [x] Abstraction
* [x] Interface
* [x] Four Pillars of OOP
* [x] OOP Mini Project
* [x] Project README
* [x] Git commit
* [x] GitHub push

---

## 🎯 Status

**Day 4 — OOP: COMPLETED ✅**

The concepts learned today will be used as the foundation for building more advanced C# and .NET applications.
