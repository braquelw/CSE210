using System;


class SimpleGoal : Goal
{
    private const int _goalType = 1;
    private bool _goalComplete;
    private int _goalPoints { get; set; }

    public SimpleGoal()
    {
    }
    public SimpleGoal(string goalName, string goalDescription, int goalPoints, bool goalComplete) : base (goalName, goalDescription)
    {
        _goalComplete = goalComplete;
        _goalPoints = goalPoints;
    }

    public override void DisplayGoalPoints()
    {
        Console.Write("How many POINTS is this goal worth? ");
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
        return string.Format($"{_goalType}|{GetGoalName()}|{GetGoalDescription()}|{GetGoalPoints()}|{_goalComplete}");
    }

    public override string ToString()
    {
        return string.Format($"[{((_goalComplete == false) ? " " : "x")}] {GetGoalName()} ({GetGoalDescription()})");
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {GetGoalPoints()} points!");
        _goalComplete = true;
    }
}