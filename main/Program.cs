using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Simple Calculator");
        Console.WriteLine("------------------");

        Console.Write("Enter first number: ");
        double firstNumber = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double secondNumber = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("First Number: " + firstNumber);
        Console.WriteLine("Second NUmber: " + secondNumber);

        Console.WriteLine();
        Console.WriteLine("Choose an operation: ");
        Console.WriteLine("1.Add");
        Console.WriteLine("2.Subtract");
        Console.WriteLine("3.Multiply");
        Console.WriteLine("4.Divide");

        Console.WriteLine();
        Console.Write("Enter your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("sum: " + (firstNumber + secondNumber));
                break;

            case 2:
                Console.WriteLine("difference: " + (firstNumber - secondNumber));
                break;

            case 3:
                Console.WriteLine("product: " + (firstNumber * secondNumber));
                break;

            case 4:
                Console.WriteLine("Quotient: " + (firstNumber / secondNumber));
                break;

            default:
                Console.WriteLine("Invalid Choice!");
                break;    
        }

    }
}