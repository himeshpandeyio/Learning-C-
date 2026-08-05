using System;
using System.Runtime.InteropServices;

namespace main
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number : ");
            int number;
            number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 != 0)
            {
                Console.WriteLine("Its a prime number");
            }
            else if(number == 1)
            {
                Console.WriteLine("1 cannot be a prime number.");
            }
            else
            {
                Console.WriteLine("It's not a prime number.");
            }
        }
    }
}
