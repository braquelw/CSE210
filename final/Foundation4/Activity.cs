using System;


public class Activity
{
    private string _date { get; set; }
    private float _time { get; set; }

    public Activity(string date, float time)
    {
        _date = date;
        _time = time;
    }

    public string GetDate()
    {
        return _date;
    }
    public float GetTime()
    {
        return _time;
    }

    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual double GetPace()
    {
        return 0;
    }
    public virtual string GetSummary()
    {
        return "";
    }
}