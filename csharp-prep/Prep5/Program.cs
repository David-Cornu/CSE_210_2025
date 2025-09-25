using System;

class Program
{
    static void Main(string[] args)
    {
        string userName;
        int userNumber;
        string inputNumber;
        int userBirthYear;
        string inputYear;
        int curentYear = DateTime.Now.Year;
        int age;

        Console.WriteLine("Welcome to the program!");
        Console.WriteLine();

        Console.Write("What is your name? ");
        userName = Console.ReadLine();
        Console.Write("What is your favorite number? ");
        inputNumber = Console.ReadLine();
        userNumber = int.Parse(inputNumber);
        Console.Write("What year were you born? ");
        inputYear = Console.ReadLine();
        userBirthYear = int.Parse(inputYear);

        userNumber *= userNumber;
        age = curentYear - userBirthYear;

        Console.WriteLine("");
        Console.WriteLine($"{userName} the square of your number is {userNumber}");
        Console.WriteLine($"{userName} you will turn {age} this year.");
    }
}