using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Random Number Guessing Game! Please guess a number between 1 and 100 to begin.");
        Console.WriteLine("");

        string playAgain = "yes";

        while (playAgain == "yes" || playAgain == "y")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int numberGuess = -1;
            int guesses = 0;

            while (numberGuess != magicNumber)
            {
                Console.Write("What is your guess? ");
                numberGuess = int.Parse(Console.ReadLine());

                if (numberGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (numberGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else{
                    Console.WriteLine("You guessed correctly!");
                }
                guesses += 1;
            }
            Console.WriteLine($"It took you {guesses} tries to get the number right!");
            Console.WriteLine("");
            Console.Write ("Do you want to play again? ");
            Console.WriteLine("");
            playAgain = Console.ReadLine();
        }
    }
}