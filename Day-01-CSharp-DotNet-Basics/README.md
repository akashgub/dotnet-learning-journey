# Day 01 — C# & .NET Basics

This is Day 01 of my **30 Days .NET Developer Learning Journey**.

Today I learned the fundamentals of C# and .NET and practiced them by building small console applications.

---

## 🎯 Learning Objectives

* Understand what .NET and C# are
* Learn basic C# syntax
* Understand variables and data types
* Learn implicit typing with `var`
* Understand constants with `const`
* Practice basic calculations
* Build small console applications
* Practice Git and GitHub workflow

---

## 📚 Topics Covered

### 1. C# & .NET Basics

Learned about:

* .NET
* C#
* .NET SDK
* .NET Runtime
* CLR
* Console applications
* Basic `dotnet` CLI commands

Important commands practiced:

```bash
dotnet --version
dotnet new console
dotnet run
dotnet build
dotnet restore
dotnet clean
dotnet publish
```

---

### 2. Variables

Learned how to declare and use variables.

Example:

```csharp
string name = "Akash";
int age = 25;
double cgpa = 3.3;
bool isStudent = true;
```

Practiced:

* `string`
* `int`
* `double`
* `bool`
* String concatenation
* String interpolation

---

### 3. Data Types

Practiced the following C# data types:

* `int`
* `long`
* `float`
* `double`
* `decimal`
* `char`
* `string`
* `bool`

Also learned that `decimal` is generally preferred for financial calculations.

Example:

```csharp
decimal salary = 50000.50m;
```

---

### 4. `var`

Learned how C# uses `var` for implicit type inference.

Example:

```csharp
var name = "Akash";       // string
var age = 25;             // int
var rating = 4.5f;        // float
var isAvailable = true;   // bool
```

Important concept:

> `var` does not mean the variable has no type. The compiler determines the type at compile time.

---

### 5. Constants & Mini Challenge

Learned about `const` and how to create values that cannot be changed after declaration.

Example:

```csharp
const decimal TaxRate = 0.05m;
```

### 🧾 Mini Challenge — Invoice Calculator

Built a simple invoice calculator using:

* `const`
* `var`
* `decimal`
* Arithmetic operators
* String interpolation

The program calculates:

```text
Subtotal = Price × Quantity
Tax = Subtotal × TaxRate
Total = Subtotal + Tax
```

Example result:

```text
Invoice Information:
--------------------
Product: Laptop
Price: 50000
Quantity: 2
Subtotal: 100000
Tax: 5000.00
Total: 105000.00
```

---

## 📂 Projects

| Project           | Description                       |
| ----------------- | --------------------------------- |
| `01-Hello-DotNet` | Basic C# console output           |
| `02-Variables`    | Variables and basic data          |
| `03-Data-Types`   | C# primitive data types           |
| `04-Var`          | Implicit type inference           |
| `05-Constants`    | Constants and invoice calculation |

---

## 🛠️ Technologies

* C#
* .NET
* .NET CLI
* Git
* GitHub

---

## ✅ Day 01 Progress

* [x] C# & .NET Basics
* [x] Variables
* [x] Data Types
* [x] `var`
* [x] `const`
* [x] Mini Invoice Challenge
* [x] Git & GitHub Practice

**Day 01 — Completed 🎉**

---

## 🚀 Next: Day 02

### C# Control Flow

Topics:

* `if`
* `else`
* `else if`
* `switch`
* `for`
* `while`
* `do-while`
* `break`
* `continue`
* Practical coding problems
