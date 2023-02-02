using System;

class Program
{
    static void Main(string[] args)
    {
        AllGoals allGoals = new AllGoals();

        // Variables
        int menuSelection = 0;

        // Opening Message
        Console.Clear();
        Console.WriteLine("Welcome to the Goal Getter App!");
        Console.WriteLine();
        Thread.Sleep(2000);

        // Menu Loop
        while (menuSelection != 6)
        {
            Menu menu = new Menu();
            allGoals.DisplayPoints(allGoals.getTotalPoints());
            allGoals.DisplayBadge(allGoals.getBadge());
            Console.WriteLine();
            menu.DisplayMainMenu();
            menuSelection = menu.DisplayGetMainMenu();
            Console.Clear();

            if (menuSelection == 1)
            {
                menu.DisplayNewGoalMenu();
                int newGoalSelection = menu.DisplayGetNewGoalMenu();
                Console.Clear();
                Goal goal = null;
                if (newGoalSelection == 1)
                {
                    goal = new SimpleGoal();
                    goal.DisplayGoalName();
                    goal.DisplayGoalDescription();
                    goal.DisplayGoalPoints();
                }
                else if (newGoalSelection == 2)
                {
                    goal = new EternalGoal();
                    goal.DisplayGoalName();
                    goal.DisplayGoalDescription();
                    goal.DisplayGoalPoints();
                }
                else
                {
                    goal = new CheckListGoal();
                    goal.DisplayGoalName();
                    goal.DisplayGoalDescription();
                    goal.DisplayGoalPoints();
                }
                // Add goal to All Goals
                if (goal != null)
                {
                    allGoals.addGoal(goal);
                }
            }

            else if (menuSelection == 2)
            {
                allGoals.DisplayGoals();
            }

            else if (menuSelection == 3)
            {
                allGoals.SaveGoals();
            }

            else if (menuSelection == 4)
            {
                allGoals.LoadGoals();
            }
            else if (menuSelection == 5)
            {
                allGoals.DisplayGoalRecordEvent();
            }
            else if (menuSelection == 6)
            {
                Console.Write("Do you want to save before you quit (y/n)? ");
                string userInput = Console.ReadLine();
                if (userInput == "y" || userInput == "yes")
                {
                    allGoals.SaveGoals();
                }
                return;
            }
        }
    }
}