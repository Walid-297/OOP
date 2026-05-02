# 🏦 Bank Account Management System

A clean and educational **Bank Account Management System** built using **C#** and **.NET 8** to demonstrate the core principles of **Object-Oriented Programming (OOP)**.

This project simulates different bank account types while showcasing real-world software engineering concepts such as:

- Abstraction
- Encapsulation
- Inheritance
- Polymorphism

---

## 📖 Overview

The system contains a base abstract account class and multiple account types that inherit from it.

Each account type implements its own business logic while sharing common banking operations such as:

- Deposit
- Withdraw
- Balance Management
- Account Information Display
- Interest Calculation

The project was designed primarily for learning and practicing OOP concepts in C#.

---

## 🧠 OOP Principles Demonstrated

| Principle | Implementation |
|------------|----------------|
| Abstraction | `Account` abstract class defines common behavior |
| Encapsulation | `balance` field is private and accessed through methods |
| Inheritance | `SavingsAccount` and `CurrentAccount` inherit from `Account` |
| Polymorphism | Each account type overrides `CalculateInterest()` differently |

---

## ✨ Features

- Abstract base account system
- Savings account implementation
- Current account implementation
- Deposit and withdrawal operations
- Interest calculation system
- Monthly fee deduction
- Console-based interaction
- Clean and modular architecture
- Beginner-friendly code structure

---

## 🛠️ Technologies Used

- **Language:** C#
- **Framework:** .NET 8
- **IDE:** Visual Studio 2022

---

## 📂 Project Structure

```text
BankAccount/
├── Account.cs              # Abstract base class
├── SavingsAccount.cs       # Savings account implementation
├── CurrentAccount.cs       # Current account implementation
├── Program.cs              # Application entry point
├── BankAccount.csproj      # Project configuration
└── BankAccount.sln         # Solution file
```

---

## 🏗️ Class Design

### Account (Abstract Base Class)

The `Account` class contains the shared functionality between all account types.

#### Responsibilities

- Store account number
- Manage account balance
- Handle deposits and withdrawals
- Define abstract interest calculation behavior

#### Key Concepts

- Cannot be instantiated directly
- Provides reusable functionality
- Forces derived classes to implement `CalculateInterest()`

---

### SavingsAccount

Represents a savings account that earns interest over time.

#### Features

- Stores interest rate
- Calculates balance-based interest
- Overrides account display behavior

#### Interest Formula

```text
Interest = Balance × InterestRate
```

---

### CurrentAccount

Represents a current account with monthly service fees.

#### Features

- Stores monthly fee
- Deducts monthly charges
- Returns zero interest
- Overrides account display behavior

---

## ⚙️ Getting Started

### Prerequisites

Make sure you have installed:

- .NET 8 SDK
- Visual Studio 2022 or VS Code

---

### Clone the Repository

```bash
git clone https://github.com/YourUsername/BankAccount.git
```

---

### Run the Project

```bash
dotnet run
```

---

## 💻 Usage Example

```csharp
Account savings = new SavingsAccount("SA-001", 0.05m, 10000);
Account current = new CurrentAccount("CA-001", 100, 5000);

savings.Deposit(2000);
current.Withdraw(500);

savings.displayinfo();
current.displayinfo();
```

---

## 🖥️ Example Output

```text
Savings Account Info:
Account Number: SA-001
Balance: 12000
Interest Rate: 0.05
Calculated Interest: 600

Current Account Info:
Account Number: CA-001
Balance: 4500
Monthly Fee: 100
Calculated Interest: 0
```

---

## ⚡ How the System Works

### Deposit Process

1. User enters an amount
2. Amount is added to account balance
3. Updated balance is stored

### Withdrawal Process

1. User requests withdrawal amount
2. Amount is deducted from balance
3. Remaining balance is updated

### Interest Calculation

The system uses **polymorphism** so each account type calculates interest differently:

- `SavingsAccount` → Returns calculated interest
- `CurrentAccount` → Returns zero

---

## 🚀 Why This Project Matters

This project is an excellent beginner-to-intermediate OOP practice project because it demonstrates how real systems use:

- Shared base classes
- Specialized child classes
- Method overriding
- Encapsulation of internal data
- Reusable software design

It also helps strengthen understanding of clean architecture and class relationships in C#.

---

## 🔮 Future Improvements

Possible enhancements include:

- Input validation
- Exception handling
- Transaction history
- File/database storage
- User authentication
- Interactive console menu
- Unit testing with xUnit
- Transfer between accounts
- Generic banking services

---

## 📚 Learning Outcomes

By building this project, you practice:

- Writing abstract classes
- Using inheritance correctly
- Applying polymorphism
- Designing reusable systems
- Structuring C# projects professionally
- Building clean object-oriented applications

---

## 📄 License

This project is licensed under the MIT License.