using System;

public class JournalEntry
{
    public string _dateOfEntry;
    public string _prompt;
    public string _response;

    public JournalEntry()
    {

    }

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_dateOfEntry}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine();
    }
}