# Day 05 — Advanced C#

This day focuses on important intermediate-level C# concepts that are commonly used in real-world .NET applications and technical interviews.

## 📚 Topics Covered

### 01. Interface

Learned how interfaces define a contract that classes must implement.

**Key concepts:**

* Interface declaration
* Interface implementation
* Methods in interfaces
* Multiple classes implementing the same interface
* Polymorphism with interfaces

**Practice:**

* `IVehicle`
* `Car`
* `Bike`

---

### 02. Abstract Class

Learned how abstract classes provide a common base for derived classes.

**Key concepts:**

* Abstract class
* Abstract method
* Concrete method
* `override`
* Cannot instantiate an abstract class
* Polymorphism

**Practice:**

* `Vehicle`
* `Car`
* `Bike`

---

### 03. Static

Learned how static members belong to the class rather than individual objects.

**Key concepts:**

* Static method
* Static member
* Calling static methods without creating objects
* `static Main()`

**Practice:**

* `StudentResult`
* Calculate total marks
* Calculate average marks

**Output:**

```text
Total: 240
Average: 80
```

---

### 04. Sealed

Learned how the `sealed` keyword prevents a class from being inherited.

**Key concepts:**

* `sealed` class
* Preventing inheritance
* Creating objects from a sealed class

**Practice:**

* `Employee` sealed class
* Tested inheritance restriction

---

### 05. Access Modifiers

Learned how access modifiers control the accessibility of classes and members.

**Key concepts:**

* `public`
* `private`
* `protected`
* `internal`
* Encapsulation
* Inheritance and protected members

**Practice Project:**

* Bank Account System
* Multiple bank accounts
* Deposit
* Withdraw
* Balance management
* Account information

---

### 06. Properties

Learned how properties provide controlled access to class data.

**Key concepts:**

* Properties
* `get`
* `set`
* Auto-properties
* `private set`
* Data validation
* Field vs Property

**Practice Project:**

* Student Information System
* Name
* Age
* CGPA
* Age validation
* CGPA validation

**Output:**

```text
Name: Akash
Age: 24
CGPA: 3.3
```

---

### 07. Nullable Types

Learned how value types can represent both a value and `null`.

**Key concepts:**

* Nullable types
* `int?`
* `double?`
* `bool?`
* `null`
* `HasValue`
* `.Value`
* Null-coalescing operator `??`
* Null-conditional operator `?.`

**Practice Project:**

* Employee Salary Information
* Nullable salary
* Nullable bonus
* Total salary calculation
* Checking salary availability

**Output:**

```text
Employee: Akash
Salary: 30000
Bonus: 0
Total Salary: 30000
Salary Available: True
```

---

### 08. Exception Handling

Learned how to handle runtime errors without crashing the application.

**Key concepts:**

* `try`
* `catch`
* `finally`
* `Exception`
* `Exception.Message`
* `throw`
* `DivideByZeroException`
* `FormatException`
* Multiple `catch` blocks

**Practice Project:**

* Bank Account Exception Handling
* Deposit validation
* Withdrawal validation
* Insufficient balance handling
* Custom exceptions using `throw`

**Output:**

```text
Current Balance: 50000
Akash deposited: 10000
Akash withdrew: 15000
Current Balance: 45000
Transaction completed.
```

---

# 💼 Interview Questions Covered

### Interface

* What is an interface?
* Why do we use interfaces?
* Interface vs abstract class

### Abstract Class

* What is an abstract class?
* Can we create an object of an abstract class?
* What is an abstract method?

### Static

* What is a static member?
* Why don't we need an object to call a static method?

### Sealed

* What is a sealed class?
* Why would we use a sealed class?

### Access Modifiers

* What is `public`?
* What is `private`?
* What is `protected`?
* What is `internal`?
* Difference between `private` and `protected`

### Properties

* What is a property?
* What is the difference between a field and a property?
* What is `get` and `set`?
* What does `private set` mean?

### Nullable Types

* What is a nullable type?
* What does `int?` mean?
* What is `HasValue`?
* What is the `??` operator?

### Exception Handling

* What is an exception?
* What is `try-catch`?
* Why do we use `finally`?
* What is `throw`?
* Difference between `Exception` and specific exceptions such as `FormatException`

---

# 🛠️ Technologies & Concepts

* C#
* .NET
* Object-Oriented Programming
* Interfaces
* Abstract Classes
* Static Members
* Sealed Classes
* Access Modifiers
* Properties
* Nullable Types
* Exception Handling
* Data Validation
* Encapsulation
* Polymorphism

---

# 🎯 Learning Outcome

After completing Day 5, I can:

* Use interfaces to define contracts
* Create and use abstract classes
* Work with static members
* Prevent inheritance using sealed classes
* Apply different access modifiers
* Use properties for controlled data access
* Work safely with nullable values
* Handle runtime exceptions using `try-catch-finally`
* Create validation errors using `throw`
* Build small practical C# applications using these concepts

---

## 📌 Day 5 Status

**Status:** ✅ Completed

**Topics Completed:** 8/8

**Practice Projects:** Completed

**Interview Preparation:** Completed

---

## 🚀 Next Step

**Day 6 — Advanced C# / Collections & Generics** 