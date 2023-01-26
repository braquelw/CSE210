public class Activity
{
    private string _activityName { get; set; }
    private string _activityDescription { get; set; }
    private int _activityDuration { get; set; }

    public Activity(string activityName, string activityDescription)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName} Activity!");
        Console.WriteLine();
        Console.WriteLine(_activityDescription);
        Console.WriteLine();
        Console.Write("How many seconds would you like this session to last? ");
        string seconds = Console.ReadLine();
        _activityDuration = int.Parse(seconds);
        Console.Clear();
        Console.Write("Prepare to begin ");
        int sleep = 0;
        while (sleep <= 2500)
        {
            Console.Write("·");
            Thread.Sleep(500);
            Console.Write("·");
            Thread.Sleep(500);
            Console.Write("·");
            Thread.Sleep(500);
            Console.Write("\b\b\b   \b\b\b");
            sleep += 1000;
        }
        Console.Clear();
        if (_activityName == "Breathing")
        {
            BreathingActivity b1 = new BreathingActivity(_activityName, _activityDescription, _activityDuration);
            b1.GetBreathingActivity();
        }
        else if (_activityName == "Reflection")
        {
            ReflectionActivity r1 = new ReflectionActivity(_activityName, _activityDescription, _activityDuration);
            r1.GetReflectionActivity();
        }
        else if (_activityName == "Listing")
        {
            ListingActivity l1 = new ListingActivity(_activityName, _activityDescription, _activityDuration);
            l1.GetListingActivity();
        }
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well Done!");
        Console.WriteLine();
        Console.WriteLine($"You have completed {_activityDuration} seconds of the {_activityName} Activity.");
        Thread.Sleep(3000);
        Console.Clear();
    }
}