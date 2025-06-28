//this is for your average, simple goal that can be completed once for points.
public class SimpleGoal : Goal
{
    private bool _isComplete;
//checks if goal is complete or not
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }
    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete;
    }

//make sure it's done once
    public override int RecordGoal()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"you finished '{_goalName}' and got {_pointsEarned} points!");
            return _pointsEarned;
        }
        else
        {
            Console.WriteLine($"looks like you already did this one.");
            return 0;
        }
    }

    public override string GetDetails()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        return $"{status} {_goalName} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_goalName},{_description},{_pointsEarned},{_isComplete}";
    }
}
