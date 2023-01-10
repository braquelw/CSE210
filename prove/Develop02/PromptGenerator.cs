using System;
using System.Collections.Generic;

public class PromptGenerator
{
    // Create a list of journal prompts
    List<String> prompts = new List<String>()
    {
        "Who was the most interesting person I interacted with today?",
        "The best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "How did I connect with my family today?",
        "What was something I did to serve another today?",
        "Who made me feel loved today?",
        "3 things I'm grateful for",
        "How did I feel prompted today?",
        "If I could never forget one thing from today, what would it be?",
        "Overall, how did today go?",
        "How did you show yourself love today?",
        "I am proud of myself because...",
        "Some of my current goals",
        "A happy memory",
        "A funny moment",
        "Something I'm looking forward to",
        "The best part of my day",
        "Something I have recently learned",
        "If I could travel into the past...",
        "If I could do anything, what would I do?"
    };
    
    public void GenerateRandomPrompt()
    {
        // Create a random instance
        Random R = new Random();
        int index = R.Next(prompts.Count);
        string randomString = prompts[index];

        // Add the current date
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        Console.WriteLine(dateText);      

        // Display random prompt and let user answer
        Console.WriteLine(randomString);
        string promptAnswer = Console.ReadLine();
        Console.WriteLine();

        // Add Entry to Journal Entries
        JournalEntry entry = new JournalEntry();
        entry._prompt = randomString;
        entry._answer = promptAnswer;
        entry._date = dateText;

        JournalDict myEntry = new JournalDict();
        myEntry._entries.Add(entry);
    }
}