using System;

class Program
{
    static void Main(string[] args)
    {
        AllActivities allActivities = new AllActivities();

        // Add Activities
        RunningActivity r1 = new RunningActivity("Feb 2, 2023", 65, 8);
        allActivities.addActivity(r1);
        BikingActivity b1 = new BikingActivity("Feb 3, 2023", 35, 18);
        allActivities.addActivity(b1);
        SwimmingActivity s1 = new SwimmingActivity("Feb 4, 2023", 20, 75);
        allActivities.addActivity(s1);

        // Display Activities
        allActivities.DisplayActivities();
        Console.WriteLine();
    }
}