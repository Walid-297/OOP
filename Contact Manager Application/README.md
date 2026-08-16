
# Contact Manager Application

A clean, console-based **Contact Manager Application** built with **C# and .NET 8** to practice and demonstrate core **Object-Oriented Programming (OOP)** principles through a small real-world domain.

The project models users and their contact information while implementing operations such as adding, editing, deleting, displaying, and searching contacts.

The main goal of this project was not simply to build a contact manager, but to strengthen my understanding of **object modeling, encapsulation, class relationships, validation, collections, and CRUD-style application logic**.

---

## Overview

The application represents a contact management system where each user can have multiple:

- Addresses
- Email accounts
- Phone numbers

The system provides a `Contact` manager responsible for managing users, while individual model classes encapsulate their own data and validation rules.

This project was built as an **OOP practice application** to develop the mindset required to translate a real-world scenario into classes, objects, relationships, and executable code.

---

# OOP Concepts Demonstrated

| Concept | Implementation |
|---------|----------------|
| **Encapsulation** | Private fields with controlled access through methods and properties |
| **Abstraction** | Separating contact-management responsibilities from individual models |
| **Composition** | `User` contains collections of `Address`, `Email`, and `Phone` objects |
| **Object Modeling** | Real-world entities are represented as dedicated C# classes |
| **Constructor Overloading** | Models support multiple ways of creating valid objects |
| **Validation** | Models validate their data before accepting values |
| **Collections** | `List<T>` is used to manage multiple related objects |
| **CRUD Operations** | Users can be added, edited, deleted, displayed, and searched |

---

# Features

- Create and manage multiple users
- Add multiple addresses to a user
- Add multiple email accounts to a user
- Add multiple phone numbers to a user
- Edit existing user information
- Delete users
- Search users across multiple fields
- Display all stored users
- Case-insensitive search
- Input validation and guard clauses
- Email format validation
- Phone number validation
- Non-empty string validation
- Constructor overloading
- Modular model and manager structure

---

# Project Structure

```text
Contact_Manager_Application/
│
├── Managers/
│   └── Contact.cs
│       # Manages the collection of users and contact operations
│
├── Models/
│   ├── Address.cs
│   │   # Represents and validates user addresses
│   │
│   ├── Email.cs
│   │   # Represents and validates email information
│   │
│   ├── Gender.cs
│   │   # Defines available gender values
│   │
│   ├── Phone.cs
│   │   # Represents and validates phone information
│   │
│   └── User.cs
│       # Represents a user and their contact information
│
└── Program.cs
    # Application entry point and demonstration
```

---

# Class Design

The application separates responsibilities between the manager and domain models.

```text
                         ┌─────────────────────────┐
                         │        Contact          │
                         ├─────────────────────────┤
                         │ - _users: List<User>    │
                         ├─────────────────────────┤
                         │ + AddUser()             │
                         │ + EditUser()            │
                         │ + RemoveUser()          │
                         │ + SearchUser()          │
                         │ + ShowAll()             │
                         └────────────┬────────────┘
                                      │
                                      │ 1..*
                                      ▼
                         ┌─────────────────────────┐
                         │          User           │
                         ├─────────────────────────┤
                         │ - _id                   │
                         │ - _firstName            │
                         │ - _lastName             │
                         │ - _gender               │
                         │ - _city                 │
                         │ - _addresses            │
                         │ - _emails               │
                         │ - _phones               │
                         └────────────┬────────────┘
                                      │
                ┌─────────────────────┼─────────────────────┐
                │                     │                     │
               1..*                 1..*                 1..*
                │                     │                     │
                ▼                     ▼                     ▼
       ┌────────────────┐    ┌────────────────┐    ┌────────────────┐
       │    Address     │    │     Email      │    │     Phone      │
       ├────────────────┤    ├────────────────┤    ├────────────────┤
       │ Place          │    │ Email          │    │ Phone          │
       │ Type           │    │ Type           │    │ Type           │
       │ Description    │    │ Description    │    │ Description    │
       └────────────────┘    └────────────────┘    └────────────────┘
```

This structure reflects a simple real-world relationship:

> A `Contact` manages many `User` objects, and each `User` owns multiple pieces of contact information.

---

# Core Design Decisions

## 1. Encapsulation

The model classes do not expose their internal state directly.

For example, validation is performed before modifying an object's internal data.

```csharp
private string _email;

public void SetEmail(string email)
{
    _email = EmailValidation(email);
}
```

This keeps the object responsible for maintaining its own valid state.

Instead of allowing any value to enter the object, the model controls how its data is modified.

---

## 2. Model-Specific Validation

Each model is responsible for validating its own data.

### Email

The email model validates that the provided value follows the expected basic format.

```csharp
if (!email.Contains("@") || !email.Contains("."))
{
    throw new ArgumentException("Invalid email format.");
}
```

### Phone

The phone model validates that the phone number:

- Contains digits only
- Does not exceed the allowed length
- Is not empty

### Address

The address model validates required fields such as:

- Place
- Type
- Description

This approach keeps validation close to the data it protects.

---

# Constructor Overloading

The project also demonstrates constructor overloading and constructor chaining.

For example, an address can be created with or without a description:

```csharp
public Address(string place, string type, string description)
{
    SetPlace(place);
    SetType(type);
    SetDescription(description);
}

public Address(string place, string type)
    : this(place, type, string.Empty)
{
}
```

This demonstrates how constructors can provide multiple ways to create an object while still maintaining a consistent initialization process.

---

# CRUD Operations

The `Contact` manager provides the main operations required to manage users.

### Create

Add a new user to the contact collection.

### Read

Display individual users or all stored users.

### Update

Edit existing user information and their associated contact details.

### Delete

Remove a user from the collection.

### Search

Search across multiple pieces of information such as:

- First name
- Last name
- City
- Addresses
- Emails
- Phone numbers

The search is designed to be case-insensitive, making it easier to locate users regardless of text casing.

---

# Technical Concepts Practiced

This project was used to practice several concepts that are important beyond this specific application:

- Designing classes from a real-world scenario
- Identifying objects and their responsibilities
- Establishing relationships between classes
- Encapsulation and controlled state modification
- Constructor design
- Constructor chaining
- Method organization
- Generic collections using `List<T>`
- Iterating through nested collections
- Input validation
- Guard clauses
- Exception handling
- CRUD application logic
- Searching through object collections
- Separating models from management logic

---

# Learning Purpose

This project is intentionally a **learning-oriented OOP application**.

The purpose was to move beyond isolated C# syntax and practice answering questions such as:

- What objects exist in the problem?
- What responsibility should each class have?
- Which class should own a particular piece of data?
- How should objects relate to each other?
- How can an object protect its own state?
- How can the design remain understandable as the application grows?

The project therefore represents a step toward learning how to **translate requirements and real-world scenarios into object-oriented designs**, rather than simply writing classes to satisfy a specification.

---

# Technologies Used

- **Language:** C#
- **Framework:** .NET 8
- **IDE:** Visual Studio 2022
- **Paradigm:** Object-Oriented Programming
- **Collections:** `List<T>`

---

# Getting Started

## Prerequisites

Make sure you have installed:

- .NET 8 SDK
- Visual Studio 2022 or another compatible IDE

## Clone the Repository

```bash
git clone https://github.com/your-username/Contact_Manager_Application.git
```

## Build the Project

```bash
dotnet build
```

## Run the Application

```bash
dotnet run
```

---

# Possible Future Improvements

The current implementation is intentionally focused on OOP fundamentals.

Possible extensions include:

- Persistent storage using files or a database
- Entity Framework Core integration
- Unit testing with xUnit
- More advanced search and filtering
- Input-driven interactive menus
- Contact grouping and categorization
- Data export and import
- Dependency injection
- Repository/service layers
- ASP.NET Core Web API version

These improvements would allow the project to evolve from a console-based OOP exercise into a more complete application architecture.

---

# Purpose

The main purpose of this project is to strengthen my **object-oriented design and implementation skills in C#** by building a small system around a realistic domain.

Rather than focusing only on making the application work, the project emphasizes understanding **why classes exist, how responsibilities are distributed, how objects communicate, and how encapsulation protects application state**.

This project forms part of my broader journey toward building larger and more maintainable **.NET applications**.
```