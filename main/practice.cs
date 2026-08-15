using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization.Metadata;


// class CalculatorProgram
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Simple Calculator");
//         Console.WriteLine("------------------");

//         Console.Write("Enter first number: ");
//         double firstNumber = Convert.ToDouble(Console.ReadLine());

//         Console.Write("Enter second number: ");
//         double secondNumber = Convert.ToDouble(Console.ReadLine());

//         Console.WriteLine();
//         Console.WriteLine("First Number: " + firstNumber);
//         Console.WriteLine("Second NUmber: " + secondNumber);

//         Console.WriteLine();
//         Console.WriteLine("Choose an operation: ");
//         Console.WriteLine("1.Add");
//         Console.WriteLine("2.Subtract");
//         Console.WriteLine("3.Multiply");
//         Console.WriteLine("4.Divide");

//         Console.WriteLine();
//         Console.Write("Enter your choice: ");
//         int choice = Convert.ToInt32(Console.ReadLine());

//         switch (choice)
//         {
//             case 1:
//                 Console.WriteLine("sum: " + (firstNumber + secondNumber));
//                 break;

//             case 2:
//                 Console.WriteLine("difference: " + (firstNumber - secondNumber));
//                 break;

//             case 3:
//                 Console.WriteLine("product: " + (firstNumber * secondNumber));
//                 break;

//             case 4:
//                 Console.WriteLine("Quotient: " + (firstNumber / secondNumber));
//                 break;

//             default:
//                 Console.WriteLine("Invalid Choice!");
//                 break;    
//         }

//     }
// }


// NUmber Guessing Game
// class NumberGuessingGame
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Number Guessing Game");
//         Console.WriteLine("---------------------");

//         Random random = new Random();

//         int secretNumber = random.Next(1, 101);
//         int attempts = 0;
//         int guess = 0;

//         while (guess != secretNumber)
//         {
//             Console.WriteLine("Enter your guess: ");
//             guess = Convert.ToInt32(Console.ReadLine());
//             attempts++;

//             if (guess == secretNumber)
//             {
//                 Console.WriteLine("You guessed correctly!");
//             }
//             else if (guess > secretNumber)
//             {
//                 Console.WriteLine("Too high!");
//             }
//             else
//             {
//                 Console.WriteLine("Too low!");
//             }
//         }

//         Console.WriteLine("You guessed the number in " + attempts + " attempts.");

//     }
// }
// arrays
// class Practice
// {
//     static void Main(string[] args)
//     {
//         string[] cars = new string[4] {"ferrari", "ford", "BMW", "mercedes"};

//         // for loop  
//         for (int i = 0; i<=cars.Length-1; i++)
//         {
//             Console.WriteLine(cars[i]);
//         }

//         Console.WriteLine();
// // foreach
//         foreach(string car in cars)
//         {
//             Console.WriteLine(car);
//         }
//     }
// }

// list
// List<string> cars = new List<string>();
// cars.Add("ferrari");
// cars.Add("ford");
// cars.Add("BMW");
// cars.Add("mercedes");

// for(int i =0; i<=cars.Count-1; i++)
// {
//     Console.WriteLine(cars[i]);
// }

// Student Grade Calculator

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("--Stuudent Grade Calculator--");
//         Console.WriteLine("------------------------------");

//         Console.Write("Enter the number of subjects: ");
//         int noOfSubjects = Convert.ToInt32(Console.ReadLine());

//         int[] marks = new int[noOfSubjects];

//         for (int i = 0; i < noOfSubjects; i++)
//         {
//             Console.Write($"Enter mark{i + 1}: ");
//             marks[i] = Convert.ToInt32(Console.ReadLine());
//         }

//         int total = CalcTotal(marks, noOfSubjects);

//         double average = (double)total / noOfSubjects;

//         string grade = CalcGrade(average);

//         Console.WriteLine("-------------------------");
//         Console.WriteLine($"Total: {total}");
//         Console.WriteLine($"Average: {average}");
//         Console.WriteLine($"Grade: {grade}");
//     }

//     static int CalcTotal(int[] marks, int noOfSubjects)
//     {
//         int total = 0;

//         for (int i = 0; i < noOfSubjects; i++)
//         {
//             total += marks[i];
//         }

//         return total;
//     }

//     static string CalcGrade(double average)
//     {
//         if (average >= 90)
//         { 
//             return "A"; 
//         }
//         else if (average >= 80)
//         {
//             return "B"; 
//         }
//         else if (average >= 70)
//         { 
//             return "C"; 
//         }
//         else if (average >= 60)
//         {
//              return "D";
//         }
//         else
//         { 
//             return "F"; 
//         }
//     }


// }

// OOP Concepts

// public class Calculator
// {
//     int num1, num2;
//     int result;

//     void Add()
//     {
//         result = num1 + num2;
//         Console.WriteLine(result);
//         Console.ReadLine();
//     }

//     void Subtract()
//     {
//         result = num1 - num2;
//         Console.WriteLine(result);
//         Console.ReadLine();
//     }

//     public static void Main(string[] args)
//     {
//         Calculator obj = new Calculator();
//         obj.num1 = 20;
//         obj.num2 = 30;
//         obj.Add();
//         obj.Subtract();
//     }
// }

// ATM Simulation

// class ATM
// {
//     // Private data
//     private double balance;
//     private int pin;

//     // Constructor
//     public ATM(double initialBalance, int initialPin)
//     {
//         balance = initialBalance;
//         pin = initialPin;
//     }

//     // Check the PIN
//     public bool CheckPin(int enteredPin)
//     {
//         return enteredPin == pin;
//     }

//     // Get the current balance
//     public double GetBalance()
//     {
//         return balance;
//     }

//     // Deposit money
//     public void Deposit(double amount)
//     {
//         if (amount > 0)
//         {
//             balance += amount;
//             Console.WriteLine("Deposit successful.");
//         }
//         else
//         {
//             Console.WriteLine("Invalid deposit amount.");
//         }
//     }

//     // Withdraw money
//     public void Withdraw(double amount)
//     {
//         if (amount <= 0)
//         {
//             Console.WriteLine("Invalid withdrawal amount.");
//         }
//         else if (amount > balance)
//         {
//             Console.WriteLine("Insufficient balance.");
//         }
//         else
//         {
//             balance -= amount;
//             Console.WriteLine("Withdrawal successful.");
//         }
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         // Create ATM with $1000 balance and PIN 1234
//         ATM atm = new ATM(1000, 1234);

//         // PIN authentication
//         int attempts = 0;
//         bool authenticated = false;

//         while (attempts < 3)
//         {
//             Console.Write("Enter PIN: ");
//             int enteredPin = Convert.ToInt16(Console.ReadLine());

//             if (atm.CheckPin(enteredPin))
//             {
//                 Console.WriteLine("Access granted!");
//                 authenticated = true;
//                 break;
//             }
//             else
//             {
//                 attempts++;
//                 Console.WriteLine("Incorrect PIN.");

//                 Console.WriteLine($"Attempts remaining: {3 - attempts}");
//             }
//         }

//         // Only show ATM menu if authentication was successful
//         if (authenticated)
//         {
//             bool running = true;

//             while (running)
//             {
//                 Console.WriteLine();
//                 Console.WriteLine("===== ATM =====");
//                 Console.WriteLine("1. Check Balance");
//                 Console.WriteLine("2. Deposit");
//                 Console.WriteLine("3. Withdraw");
//                 Console.WriteLine("4. Exit");

//                 Console.Write("Choose an option: ");
//                 int choice = Convert.ToInt16(Console.ReadLine());

//                 switch (choice)
//                 {
//                     case 1:
//                         Console.WriteLine(
//                             $"Balance: ${atm.GetBalance():F2}");
//                         break;

//                     case 2:
//                         Console.Write("Enter deposit amount: ");
//                         double depositAmount =
//                             Convert.ToDouble(Console.ReadLine());

//                         atm.Deposit(depositAmount);
//                         break;

//                     case 3:
//                         Console.Write("Enter withdrawal amount: ");
//                         double withdrawalAmount =
//                             Convert.ToDouble(Console.ReadLine());

//                         atm.Withdraw(withdrawalAmount);
//                         break;

//                     case 4:
//                         Console.WriteLine(
//                             "Thank you for using the ATM!");

//                         running = false;
//                         break;

//                     default:
//                         Console.WriteLine("Invalid option.");
//                         break;
//                 }
//             }
//         }
//         else
//         {
//             Console.WriteLine();
//             Console.WriteLine("Too many incorrect attempts.");
//             Console.WriteLine("Access denied.");
//         }
//     }
// }

// Learning OOP
// class Student
// {
//     public string? Name;
//     public int Age;
//     public string? Course;

//     public void TakeInput()
//     {

//         Console.Write($"Enter the name of student: ");
//         Name = Console.ReadLine();

//         Console.Write($"Enter the age of student: ");
//         Age = Convert.ToInt32(Console.ReadLine());

//         Console.Write($"Enter the course of student: ");
//         Course = Console.ReadLine();

//     }

//     public void Display()
//     {
//         Console.WriteLine($"Name: {Name}");
//         Console.WriteLine($"Age: {Age}");
//         Console.WriteLine($"Course: {Course}");
//     }

// }

// class Program
// {
//     static void Main()
//     {
//         Console.Write("How many studennts do you want to enter? ");
//         int numberOfStudents = Convert.ToInt32(Console.ReadLine());

//         Student[] students = new Student[numberOfStudents];

//         for (int i = 0; i < numberOfStudents; i++)
//         {
//             Console.WriteLine($"\n--- Student {i + 1} ---");

//             students[i] = new Student();
//             students[i].TakeInput();
//         }

//         Console.WriteLine("\n===== Student Details =====");

//         for (int i = 0; i < numberOfStudents; i++)
//         {
//             students[i].Display();
//             Console.WriteLine();
//         }

//     }
// }

class Program
{
    public Program()
    {
        Console.WriteLine("Hello I'm Khabib");
    }

    static void Main(string[] args)
    {
        Program obj = new Program();
        Console.ReadLine();
    }
}