using System;

class Program
{
    static void Main(string[] args)
    {
        string game = "yes";
        //string userNumber;
        //int magicNumber;
        string userInput;
        int inputnumber = 0;
        int turnCount = 0;
        int number;


        while (game == "yes")
        {
            Console.WriteLine("Welcome to the number guessing game!");
            Random randomGenerator = new Random();
            number = randomGenerator.Next(1, 100);
            //Console.WriteLine("Please enter a magic number: ");
            //userNumber = Console.ReadLine();

            //magicNumber = int.Parse(userNumber);

            while (inputnumber != number)
            {
                Console.WriteLine("What is your guess? ");
                userInput = Console.ReadLine();
                inputnumber = int.Parse(userInput);
                turnCount += 1;

                if (inputnumber < number)
                {
                    Console.WriteLine("Higher.");
                }
                else if (inputnumber > number)
                {
                    Console.WriteLine("Lower.");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"You took {turnCount} guesses.");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Would you like to play again?");
            Console.WriteLine("Yes or No? ");
            turnCount = 0;
            game = Console.ReadLine();
            Console.ReadLine();
        }
    }
}