using System;
using System.IO.Pipes;

class Program
{
    static void Main(string[] args)
    {
        string _fName = "none";
        string _lName = "none";

        Console.Write("What is your first name? : ");
        _fName = Console.ReadLine();

        Console.WriteLine();

        Console.Write("What is your last name? : ");
        _lName = Console.ReadLine();

        Console.WriteLine();

        Console.WriteLine($"Your name is {_lName}. {_fName} {_lName}");
    }
}