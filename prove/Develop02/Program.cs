using System;

class Program
{
    static void Main(string[] args)
    {
        // variables
        int user_choice = 0;

        // Welcome the user
        Console.WriteLine("Welcome to the Journal Program!");

        // Menu Items
        while (user_choice != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string user_input = Console.ReadLine();
            user_choice = int.Parse(user_input);
            Console.WriteLine("");

            // If user chooses 1. Write
            if (user_choice == 1)
            {
                PromptGenerator myPrompt = new PromptGenerator();
                myPrompt.GenerateRandomPrompt();
            }

            // If user chooses 2. Display
            if (user_choice == 2)
            {
                
            }

            // If user chooses 3. Load
            if (user_choice == 3)
            {
                
            }

            // If user chooses 4. Save
            if (user_choice == 4)
            {
                
            }

            // If user chooses 5. Quit
            if (user_choice == 5)
            {
                
            }
        }
    }
}