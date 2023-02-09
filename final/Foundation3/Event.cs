using System;


public class Event
{
    private string _eventName { get; set; }
    private string _eventDescription { get; set; }
    private string _eventDate  { get; set; }
    private string _eventTime { get; set; }
    private string _eventAddress { get; set; }

    public Event(string eventName, string eventDescription, string eventDate, string eventTime, string eventAddress)
    {
        _eventName = eventName;
        _eventDescription = eventDescription;
        _eventDate = eventDate;
        _eventTime = eventTime;
        _eventAddress = eventAddress;
    }

    public void ShortDescription()
    {
        Console.WriteLine($"{_eventName}\r\n{_eventDescription}\r\n{_eventDate}");
        Console.WriteLine();
    }
    public void StandardDetails()
    {
        Console.WriteLine($"{_eventName}\r\n{_eventDescription}\r\n{_eventDate}\r\n{_eventTime}\r\n{_eventAddress}");
        Console.WriteLine();
    }
    public string GetStandardDetails()
    {
        return $"{_eventName}\r\n{_eventDescription}\r\n{_eventDate}\r\n{_eventTime}\r\n{_eventAddress}";
    }
}