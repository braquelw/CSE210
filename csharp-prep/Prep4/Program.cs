using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int addNumber = -1;
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Create a list of numbers
        while (addNumber != 0)
        {
            Console.Write ("Enter a Number: ");
            string userInput = Console.ReadLine();
            addNumber = int.Parse(userInput);

            if (addNumber != 0)
            {
                numbers.Add(addNumber);
            }
        }

        // Get the Sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum of these numbers is: {sum}");

        // Compute the Average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Find the Max
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");

        // Sort the List
        numbers.Sort();
        foreach(int x in numbers)
        {
            Console.WriteLine(x);
        }
    }
}