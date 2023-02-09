using System;


public class LectureEvent : Event
{
    private string _speakerName { get; set; }
    private int _capacity { get; set; }

    public LectureEvent(string eventName, string eventDescription, string eventDate, string eventTime, string eventAddress, string speakerName, int capacity) : base(eventName, eventDescription, eventDate, eventTime, eventAddress)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    public void LectureFullDetails()
    {
        Console.WriteLine($"{GetStandardDetails()}\r\nSpeaker: {_speakerName}\r\nMax Capacity: {_capacity}");
        Console.WriteLine();
    }
}