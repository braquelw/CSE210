using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        float gradePercentage = float.Parse(userInput);

        string letter = "";

        if (gradePercentage >= 90)
        {
            letter = ("A");
        }
        else if (gradePercentage >= 80)
        {
            letter = ("B");
        }
        else if (gradePercentage >= 70)
        {
            letter = ("C");
        }
        else if (gradePercentage >= 60)
        {
            letter = ("D");
        }
        else
        {
            letter = ("F");
        }

        string sign = "";
        
        if (gradePercentage < 97 && gradePercentage > 59)
        {
            if ((gradePercentage % 10) >= 7)
            {
                sign = ("+");
            }
            else if ((gradePercentage % 10) <= 3)
            {
                sign = ("-");
            }
            else
            {
                sign = ("");
            }
        } 
        
        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the Class!");
        }
        else
        {
            Console.WriteLine("You did not pass the class, hopefully you'll have better luck next time!");
        }
    }
}