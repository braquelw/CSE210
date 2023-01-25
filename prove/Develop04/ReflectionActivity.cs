public class ReflectionActivity : Activity
{
    private string _randomPrompt { get; set; }
    private string _reflectionQuestion { get; set; }
    private int _duration { get; set; }

    public ReflectionActivity(string activityName, string activityDescription, int seconds) : base(activityName, activityDescription)
    {
        _duration = seconds;
        _randomPrompt = GetPrompt();
        _reflectionQuestion = GetQuestion();
    }

    public string GetPrompt()
    {
        List<string> prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
            "Think of a time you felt loved by the Savior.",
            "Think of a time you accomplished a task you thought was impossible."
        };
        Random i = new Random();
        int index = i.Next(prompts.Count);
        string prompt = prompts[index];
        return prompt;
    }
    public string GetQuestion()
    {
        List<string> questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you feel when it was complete?",
            "What made this time different than other times?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
            "What principles did you learn?",
            "How can you teach others about this?",
            "How did you feel during the experience?",
            "What would you say to someone experiencing something similar?",
            "Is this something you would like to experience again?",
            "How did it help you grow?"
        };
        Random i = new Random();
        int index = i.Next(questions.Count);
        string question = questions[index];
        questions.RemoveAt(index);
        return question;
    }

    public void GetReflectionActivity()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("- " + _randomPrompt);
        Console.WriteLine();
        Console.WriteLine("When you are ready, press 'enter'");
        Console.ReadLine();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.Clear();
            string question = GetQuestion();
            Console.Write("> " + question + " ");
            int count = 0;
            while (count < 7)
            {
                Console.Write("·");
                Thread.Sleep(500);
                Console.Write("·");
                Thread.Sleep(500);
                Console.Write("·");
                Thread.Sleep(500);
                Console.Write("\b\b\b   \b\b\b");
                count += 1;
            }
            currentTime = DateTime.Now;
        }
        Console.Clear();
    }
}
