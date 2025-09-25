using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput;
        float userNumber = 1;
        float numberCount = -1;
        float average;
        float total = 0;
        float highestNumber = 0;
        List<float> numbers = new List<float>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userInput = Console.ReadLine();
            userNumber = float.Parse(userInput);

            numbers.Add(userNumber);
        }

        foreach (int n in numbers)
        {
            total += n;
            numberCount += 1;
            if (n > highestNumber)
            {
                highestNumber = n;
            }
        }

        average = total / numberCount;

        Console.WriteLine($"The total is: {total}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The highest number is {highestNumber}");

    }
}