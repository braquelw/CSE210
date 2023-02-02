using System;


public class CheckListGoal : Goal
{
    private const int _goalType = 3;
    private int _goalPoints { get; set; }
    private int _goalTimes { get; set; }
    private int _goalBonus { get; set; }
    private int _runningTimes = 0;
    private int _totalPoints = 0;
    private bool _goalComplete;

    public CheckListGoal()
    {
    }
    public CheckListGoal(string goalName, string goalDescription, int goalPoints, int goalTimes, int runningTimes, int goalBonus, bool goalComplete) : base (goalName, goalDescription)
    {
        _goalPoints = goalPoints;
        _goalTimes = goalTimes;
        _runningTimes = runningTimes;
        _goalBonus = goalBonus;
        _goalComplete = goalComplete;
    }

    public override void DisplayGoalPoints()
    {
        Console.Write("How many TIMES do you want to complete this goal? ");
        _goalTimes = int.Parse(Console.ReadLine());
        Console.Write("How many POINTS is this goal worth each time you do it? ");
        _goalPoints = int.Parse(Console.ReadLine());
        Console.Write($"How much is the BONUS for completing this goal {_goalTimes} times? ");
        _goalBonus = int.Parse(Console.ReadLine());
        return;
    }
    public int GetPoints()
    {
        return _goalPoints;
    }
    public override int GetGoalPoints()
    {
        if (_runningTimes >= _goalTimes)
        {
            _totalPoints = _goalPoints + _goalBonus;
        }
        else if (_runningTimes < _goalTimes)
        {
            _totalPoints = _goalPoints;
        }
        return _totalPoints;
    }
    public int GetGoalTimes()
    {
        return _goalTimes;
    }
    public int GetGoalBonus()
    {
        return _goalBonus;
    }
    public int GetRunningTimes()
    {
        return _runningTimes;
    }
    
    public override bool GetGoalStatus()
    {
        return _goalComplete;
    }

    
    public override string ToCSVRecord()
    {
        return string.Format($"{_goalType}|{GetGoalName()}|{GetGoalDescription()}|{GetPoints()}|{GetGoalTimes()}|{GetRunningTimes()}|{GetGoalBonus()}|{_goalComplete}");
    }

    public override string ToString()
    {
        return string.Format($"[{((_goalComplete == false) ? " " : "x")}] {GetGoalName()} ({GetGoalDescription()}) - Currently Completed: {GetRunningTimes()}/{GetGoalTimes()}");
    }

    public override void RecordEvent()
    {
        _runningTimes += 1;
        Console.WriteLine($"Congratulations! You have earned {GetGoalPoints()} points!");
        if (_runningTimes >= _goalTimes)
        {
            _goalComplete = true;
            Console.WriteLine("*** You have completed this goal & earned the BONUS!! ***");
        }
        else if (_runningTimes < _goalTimes)
        {
            _goalComplete = false;
        }
    }
}