using System;


public class AllActivities
{
    public List<Activity> allActivities = new List<Activity>();

    public void addActivity(Activity _activity)
    {
        allActivities.Add(_activity);
    }

    public void DisplayActivities()
    {
        if (allActivities.Count == 0)
        {
            Console.WriteLine("No activities have been logged");
            return;
        }
        Console.WriteLine("Your activities are:");
        foreach (Activity activity in allActivities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}