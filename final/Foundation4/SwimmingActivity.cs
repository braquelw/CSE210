using System;


public class SwimmingActivity : Activity
{
    private int _laps { get; set; }

    public SwimmingActivity(string date, float time, int laps) : base(date, time)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        double miles = Math.Round(_laps * 50 / 1000 * 0.62, 2);
        return miles;
    }
    public override double GetSpeed()
    {
        double mph = Math.Round((GetDistance() / GetTime()) * 60, 2);
        return mph;
    }
    public override double GetPace()
    {
        double pace = Math.Round(GetTime() / GetDistance(), 2);
        return pace;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Swimming ({GetTime()} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}