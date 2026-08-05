using System;

class NUmGuGm
{
    static void Main(string[] args)
    {
        Console.WriteLine("NUmber Guessing Game");
        Console.WriteLine("----------------------");

        Random random = new Random();

        int secretNumber = random.Next(1,101);

        Console.WriteLine(secretNumber);
    }
}