using System;


public class ReceptionEvent : Event
{
    private string _rsvpEmail { get; set; }

    public ReceptionEvent(string eventName, string eventDescription, string eventDate, string eventTime, string eventAddress, string rsvpEmail) : base(eventName, eventDescription, eventDate, eventTime, eventAddress)
    {
        _rsvpEmail = rsvpEmail;
    }

    public void ReceptionFullDetails()
    {
        Console.WriteLine($"Event Type: Reception\r\n{GetStandardDetails()}\r\nRSVP: {_rsvpEmail}");
        Console.WriteLine();
    }
}