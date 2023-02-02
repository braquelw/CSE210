using System;


public class Menu
{
    private List<string> mainMenu, createGoalMenu;
    private int mainMenuSelection;
    private int newGoalSelection;

    public Menu()
    {
        mainMenu = new List<string>
        {
            "Menu Options:",
            "  1. Create New Goal",
            "  2. List Goals",
            "  3. Save Goals",
            "  4. Load Goals",
            "  5. Record Event",
            "  6. Quit"
        };

        createGoalMenu = new List<string>
        {
            "The types of Goals are:",
            "  1. Simple Goal",
            "  2. Eternal Goal",
            "  3. CheckList Goal"
        };
    }

    public void DisplayMainMenu()
    {
        foreach (string menuItem in mainMenu)
        {
            Console.WriteLine(menuItem);
        }
    }
    public int DisplayGetMainMenu()
    {
        Console.Write("Select a choice: ");
        return int.Parse(Console.ReadLine());
    }
    public int GetMainMenuSelection()
    {
        return mainMenuSelection;
    }

    public void DisplayNewGoalMenu()
    {
        foreach (string menuItem in createGoalMenu)
        {
            Console.WriteLine(menuItem);
        }
    }
    public int DisplayGetNewGoalMenu()
    {
        Console.Write("Select a Choice: ");
        return int.Parse(Console.ReadLine());
    }
    public int GetNewGoalSelection()
    {
        return newGoalSelection;
    }
}