using System;
class MainProgram
{
    public static void Main(String[] args)
    {
        Console.WriteLine("What's your name?");
        string name = Console.ReadLine();
        string NAME =  .ToUpper();
        string Name = NAME.Insert(2,"@@");
        Console.WriteLine("Hello! " + Name + ".");
    }
}

