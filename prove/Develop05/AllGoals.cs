using System;


class AllGoals
{
    private List<Goal> allGoals = new List<Goal>();
    private int totalPoints;
    private string badge;
    private string _fileName;

    public string GetFileName()
    {
        return _fileName;
    }
    public void SetFileName(string fileName)
    {
        _fileName = fileName;
    }

    public void addGoal(Goal _goal)
    {
        allGoals.Add(_goal);
    }

    public int getTotalPoints()
    {
        return totalPoints;
    }
    public string getBadge()
    {
        int level = totalPoints / 1000;
        if (level >= 1)
        {
            badge = $"Level {level}";
        }
        else
        {
            badge = "Novice";
        }
        return badge;
    }

    public void DisplayPoints(int totalPoints)
    {
        Console.WriteLine($"Total Points: {totalPoints}");
    }
    public void DisplayBadge(string badge)
    {
        Console.WriteLine($"Status: {badge}");
    }

    public void DisplayGoals()
    {
        if (allGoals.Count() == 0)
        {
            Console.WriteLine("No goals have been created or loaded.");
            return;
        }
        Console.WriteLine("The goals are:");
        foreach (Goal goal in allGoals)
        {
            Console.WriteLine($"{allGoals.IndexOf(goal) + 1}. {goal.ToString()}");
        }
        Console.WriteLine();
    }

    public void SaveGoals()
    {
        if (allGoals.Count() == 0)
        {
            Console.WriteLine("There are no goals to save.");
            Console.WriteLine();
            return;
        }
        Console.Write("Do you want to LOAD a file before you SAVE (y/n)? ");
        string userInput = Console.ReadLine();
        if (userInput == "y" || userInput == "yes")
        {
            LoadGoals();
        }
        Console.WriteLine("Please enter the FileName you want to SAVE: ");
        _fileName = Console.ReadLine();
        string fileToSave = _fileName;
        List<string> saveGoals = new List<string>();
        // Save Points
        saveGoals.Add(totalPoints.ToString());
        // Convert to CSV and Save Goals
        foreach (Goal goal in allGoals)
        {
            saveGoals.Add(goal.ToCSVRecord());
        }
        SaveLoadCSV.SaveToCSV(saveGoals, fileToSave);
    }

    public void LoadGoals()
    {
        List<string> fileGoals;
        Console.WriteLine("Please enter the FileName you want to LOAD: ");
        _fileName = Console.ReadLine();
        fileGoals = SaveLoadCSV.LoadFromCSV(_fileName);
        Goal goal = null;
        foreach (string goalInFile in fileGoals)
        {
            string[] goalParts = goalInFile.Split('|');
            int goalType = int.Parse(goalParts[0]);
            if (goalType == 1)
            {
                goal = new SimpleGoal(goalParts[1], goalParts[2], int.Parse(goalParts[3]), bool.Parse(goalParts[4]));
            }
            else if (goalType == 2)
            {
                goal = new EternalGoal(goalParts[1], goalParts[2], int.Parse(goalParts[3]), int.Parse(goalParts[4]), bool.Parse(goalParts[5]));
            }
            else if (goalType == 3)
            {
                goal = new CheckListGoal(goalParts[1], goalParts[2], int.Parse(goalParts[3]), int.Parse(goalParts[4]), int.Parse(goalParts[5]), int.Parse(goalParts[6]), bool.Parse(goalParts[7]));
            }
            else
            {
                totalPoints = goalType;
            }

            if (goal != null && allGoals.Contains(goal) == false)
            {
                allGoals.Add(goal);
            }
        }
    }

    public void DisplayGoalRecordEvent()
    {
        Console.WriteLine("The Goals are:");
        foreach (Goal goal in allGoals)
        {
            Console.WriteLine(string.Format($"{allGoals.IndexOf(goal) + 1}. [{((goal.GetGoalStatus() == false) ? " " : "x")}] {goal.GetGoalName()}"));
        }
        Console.Write("Which goal did you complete? ");
        int recordEvent = int.Parse(Console.ReadLine()) - 1;
        Console.Clear();
        bool status = allGoals[recordEvent].GetGoalStatus();
        if (status == false)
        {
            allGoals[recordEvent].RecordEvent();
            totalPoints += allGoals[recordEvent].GetGoalPoints();
            Console.WriteLine(string.Format($"You now have {totalPoints.ToString()} points!"));
            Console.WriteLine();
            Thread.Sleep(5000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine("That goal is already Completed!");
            Console.WriteLine();
            return;
        }
    }
}