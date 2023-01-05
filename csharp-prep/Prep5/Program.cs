using System;

class Program
{
    static void Main(string[] args)
    {
        //Functions
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);

        // Display Welcome Message
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        
        // Get User's Name
        static string PromptUserName()
        {
            Console.Write("Enter your Name: ");
            string name = Console.ReadLine();
            return name;
        }

        // Get User's Favorite Number
        static int PromptUserNumber()
        {
            Console.Write("Enter your Favorite Number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        // Square's the User's Number
        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }

        // Display Result Message
        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}.");
        }
    }
}