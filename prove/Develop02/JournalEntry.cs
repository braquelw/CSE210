using System;

public class JournalEntry
{
    public string _dateOfEntry { get; set; }
    public string _prompt { get; set; }
    public string _response { get; set; }

    public JournalEntry()
    {
        
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_dateOfEntry}, Prompt: {_prompt}, Response: {_response}");
        Console.WriteLine();
    }
}