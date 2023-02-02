using System;


public class EternalGoal : Goal
{
    private const int _goalType = 2;
    private int _goalPoints { get; set; }
    private int _runningTimes = 0;
    private bool _goalComplete = false;

    public EternalGoal()
    {
    }
    public EternalGoal(string goalName, string goalDescription, int goalPoints, int runningTimes, bool goalComplete) : base (goalName, goalDescription)
    {
        _goalPoints = goalPoints;
        _runningTimes = runningTimes;
        _goalComplete = goalComplete;
    }
        public int GetRunningTimes()
    {
        return _runningTimes;
    }

    public override void DisplayGoalPoints()
    {
        Console.Write("How many POINTS is this goal worth each time you complete it? ");
        _goalPoints = int.Parse(Console.ReadLine());
        return;
    }
    public override int GetGoalPoints()
    {
        return _goalPoints;
    }
    
    public override bool GetGoalStatus()
    {
        return _goalComplete;
    }

    public override string ToCSVRecord()
    {
        return string.Format($"{_goalType}|{GetGoalName()}|{GetGoalDescription()}|{GetGoalPoints()}|{GetRunningTimes()}|{_goalComplete}");
    }

    public override string ToString()
    {
        return string.Format($"[ ] {GetGoalName()} ({GetGoalDescription()}) - Completed {GetRunningTimes()} times");
    }

    public override void RecordEvent()
    {
        _runningTimes += 1;
        Console.WriteLine($"Congratulations! You have earned {GetGoalPoints()} points!");
    }
}