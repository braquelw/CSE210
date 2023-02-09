using System;


public class RunningActivity : Activity
{
    private double _distance { get; set; }

    public RunningActivity(string date, float time, double distance) : base(date, time)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
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
        return $"{GetDate()} Running ({GetTime()} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}