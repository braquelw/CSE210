using System;


public class BikingActivity : Activity
{
    private int _speed { get; set; }

    public BikingActivity(string date, float time, int speed) : base(date, time)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetDistance()
    {
        double miles = Math.Round((GetSpeed() * GetTime()) / 60, 2);
        return miles;
    }
    public override double GetPace()
    {
        double pace = Math.Round(GetTime() / GetDistance(), 2);
        return pace;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Biking ({GetTime()} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}