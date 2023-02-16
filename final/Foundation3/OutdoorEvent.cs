using System;


public class OutdoorEvent : Event
{
    private string _weather { get; set; }

    public OutdoorEvent(string eventName, string eventDescription, string eventDate, string eventTime, string eventAddress, string weather) : base(eventName, eventDescription, eventDate, eventTime, eventAddress)
    {
        _weather = weather;
    }

    public void OutdoorFullDetails()
    {
        Console.WriteLine($"Event Type: Outdoor\r\n{GetStandardDetails()}\r\nWeather: {_weather}");
        Console.WriteLine();
    }
}