🧠 Exam System – C# OOP Project

🎥 Watch Demo Video
🎥 [Watch Demo Video](https://drive.google.com/drive/folders/15d9nQMW3lHCYYhv8JGl3CcqFGJb3yRQC?usp=sharing)

📘 Overview

Exam System is a fully object-oriented project built in C# that simulates an examination environment.
It demonstrates core OOP principles — inheritance, polymorphism, encapsulation, abstraction, and interface implementation — with clean architecture and extensibility in mind.

The system supports:

🎓 Multiple exam types (Final, Practical)

❓ Various question types (MCQ, True/False)

🧾 Answer handling, validation, and subject association

🧬 Cloning and comparison using ICloneable and IComparable

⚙️ Constructor chaining, overriding, and ToString() enhancements

🚀 Features

✅ Object-oriented design with base and derived classes
✅ Implements interfaces (ICloneable, IComparable)
✅ Supports multiple question and exam types
✅ Centralized validation via ValidationHelper
✅ Demonstrates real-world OOP techniques and class relationships
✅ Clean, modular, and maintainable codebase

🏗️ Project Structure
Exam_System/
│
├── Models/
│   ├── Question.cs
│   ├── MCQQuestion.cs
│   ├── TrueFalseQuestion.cs
│   ├── Exam.cs
│   ├── FinalExam.cs
│   ├── PracticalExam.cs
│   ├── Answer.cs
│   ├── Subject.cs
│   └── ValidationHelper.cs
│
├── Interfaces/
│   ├── ICloneable.cs
│   └── IComparable.cs
│
├── Program.cs
└── README.md

🧩 Key OOP Concepts Used
Concept	Implementation Example
Inheritance	FinalExam and PracticalExam inherit from Exam
Polymorphism	Overriding ShowExam() in different exam types
Abstraction	Abstract base class Question
Encapsulation	Private fields with public properties
Interfaces	Implementing ICloneable and IComparable
Validation	Static ValidationHelper ensures input safety
🛠️ Technologies

Language: C#

Paradigm: Object-Oriented Programming (OOP)

IDE: Visual Studio / Visual Studio Code

Framework: .NET

🎯 Purpose

This project serves as a practical demonstration of C# OOP fundamentals — perfect for students and developers looking to understand class relationships, interface use, inheritance hierarchies, and data validation through a real-world example.
