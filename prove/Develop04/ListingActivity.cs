public class ListingActivity : Activity
{
    private string _randomPrompt { get; set; }
    private int _duration { get; set; }

    public ListingActivity(string activityName, string activityDescription, int seconds) : base(activityName, activityDescription)
    {
        _duration = seconds;
        _randomPrompt = GetPrompt();
    }

        public string GetPrompt()
    {
        List<string> prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are some of your personal strengths?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
            "What are you proud of yourself for?",
            "What are some things you are grateful for?",
            "How did you follow Christ this week?"
        };
        Random i = new Random();
        int index = i.Next(prompts.Count);
        string prompt = prompts[index];
        return prompt;
    }

    public void GetListingActivity()
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine("- " + _randomPrompt);
        Console.WriteLine();
        Thread.Sleep(2000);
        Console.Write("You may begin in: ");
        Console.Write("3");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.WriteLine();
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        int count = 0;
        while (currentTime < futureTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count += 1;
            currentTime = DateTime.Now;
        }
        Console.WriteLine();
        Console.WriteLine($"You listed {count} items!");
        Thread.Sleep(3000);
        Console.Clear();
    }
}