using System;
using System.Globalization;
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

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--Stuudent Grade Calculator--");
        Console.WriteLine("------------------------------");

        Console.Write("Enter the number of subjects: ");
        int noOfSubjects = Convert.ToInt32(Console.ReadLine());

        int[] marks = new int[noOfSubjects];

        for (int i = 0; i < noOfSubjects; i++)
        {
            Console.Write($"Enter mark{i + 1}: ");
            marks[i] = Convert.ToInt32(Console.ReadLine());
        }

        int total = CalcTotal(marks, noOfSubjects);

        double average = (double)total / noOfSubjects;

        string grade = CalcGrade(average);

        Console.WriteLine("-------------------------");
        Console.WriteLine($"Total: {total}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Grade: {grade}");
    }

    static int CalcTotal(int[] marks, int noOfSubjects)
    {
        int total = 0;

        for (int i = 0; i < noOfSubjects; i++)
        {
            total += marks[i];
        }

        return total;
    }

    static string CalcGrade(double average)
    {
        if (average >= 90)
        { 
            return "A"; 
        }
        else if (average >= 80)
        {
            return "B"; 
        }
        else if (average >= 70)
        { 
            return "C"; 
        }
        else if (average >= 60)
        {
             return "D";
        }
        else
        { 
            return "F"; 
        }
    }


}