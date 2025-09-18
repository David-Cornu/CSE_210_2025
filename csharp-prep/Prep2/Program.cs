using System;

class Program
{
    static void Main(string[] args)
    {
        int _gradePercent = 0;
        string _gradeInput = "0";
        string _message = "Your grade is";

        Console.Write("What is your grade percent? ");
        _gradeInput = Console.ReadLine();

        Console.WriteLine("");

        _gradePercent = int.Parse(_gradeInput);

        if (_gradePercent >= 90)
        { Console.WriteLine($"{_message} A."); }
        else if (_gradePercent >= 80)
        { Console.WriteLine($"{_message} B."); }
        else if (_gradePercent >= 70)
        { Console.WriteLine($"{_message} C."); }
        else if (_gradePercent >= 60)
        { Console.WriteLine($"{_message} D."); }
        else
        { Console.WriteLine($"{_message} f."); }
    }
}