using System;

class Program
{
    static void Main(string[] args)
    {
        // variables
        int b = 0;
        int r = 0;
        int l = 0;

        // Welcome the user and display the Menu
        Console.Clear();
        Console.WriteLine("Welcome to the Mindfulness Activity App");
        int userChoice = 0;
        while (userChoice != 4)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Breathing Activity");
            Console.WriteLine("  2. Reflection Activity");
            Console.WriteLine("  3. Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the Menu: ");
            string userInput = Console.ReadLine();
            userChoice = int.Parse(userInput);
            Console.Clear();

            if (userChoice == 1)
            {
                Activity a1 = new Activity("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                a1.DisplayStartingMessage();
                a1.DisplayEndingMessage();
                b += 1;
            }
            if (userChoice == 2)
            {
                Activity a2 = new Activity("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                a2.DisplayStartingMessage();
                a2.DisplayEndingMessage();
                r += 1;
            }
            if (userChoice == 3)
            {
                Activity a3 = new Activity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certatin area.");
                a3.DisplayStartingMessage();
                a3.DisplayEndingMessage();
                l += 1;
            }
        }
        Console.WriteLine("You completed each activity the following number of times:");
        Console.WriteLine($"Breathing Activity: {b}");
        Console.WriteLine($"Reflection Activity: {r}");
        Console.WriteLine($"Listing Activity: {l}");
        Thread.Sleep(2000);
        Console.WriteLine("Have a nice day!");
    }
}