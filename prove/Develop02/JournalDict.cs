using System;

public class JournalDict
{
    public List<JournalEntry> _entries = new List<JournalEntry>();

    public void Display()
    {
        foreach (JournalEntry entry in _entries)
        {
            entry.Display();
        }
    }
}