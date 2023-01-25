public class BreathingActivity : Activity
{
    private string _breatheIn { get; set; }
    private string _breatheOut { get; set; }
    private int _duration { get; set; }

    public BreathingActivity(string activityName, string activityDescription, int seconds) : base(activityName, activityDescription)
    {
        _breatheIn = "Breathe In ... ";
        _breatheOut = "Breathe Out ... ";
        _duration = seconds;
    }

    public void GetBreathingActivity()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.Write(_breatheIn);
            Console.Write("(5)");
            Thread.Sleep(1000);
            Console.Write("\b\b  \b\b");
            Console.Write(" 4 )");
            Thread.Sleep(1000);
            Console.Write("\b\b\b   \b\b\b");
            Console.Write(" 3  )");
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b    \b\b\b\b");
            Console.Write(" 2   )");
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b\b     \b\b\b\b\b");
            Console.Write(" 1    )");
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b           \b\b\b\b\b\b\b\b\b\b\b");
            Console.WriteLine();
            Console.Write(_breatheOut);
            Console.Write("(    5    )");
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b\b\b\b       \b\b\b\b\b\b\b");
            Console.Write("4   )");
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b\b\b      \b\b\b\b\b\b");
            Console.Write("3  )");
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b\b     \b\b\b\b\b");
            Console.Write("2 )");
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b    \b\b\b\b");
            Console.Write("1)");
            Thread.Sleep(1000);
            Console.Write("\b\b\b   \b\b\b");
            Console.WriteLine();
            currentTime = DateTime.Now;
        }
        Console.Clear();
    }
}