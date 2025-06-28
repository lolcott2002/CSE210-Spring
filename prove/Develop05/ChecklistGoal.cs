// this is for goals that need to be done multiple times
public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _targetAmount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetAmount, int bonusPoints) : base(name, description, points)
    {
        _amountCompleted = 0;
        _targetAmount = targetAmount;
        _bonusPoints = bonusPoints;
    }

    // this should load from a file
    public ChecklistGoal(string name, string description, int points, int targetAmount, int bonusPoints, int amountCompleted) : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _targetAmount = targetAmount;
        _bonusPoints = bonusPoints;
    }

    public override int RecordGoal()
    {
        _amountCompleted++;
        int pointsGained = _pointsEarned;

        if (_amountCompleted == _targetAmount)
        {
            pointsGained += _bonusPoints;
            Console.WriteLine($"Nice! looks like you've done '{_goalName}' {_targetAmount} times, plus you've gotten {_bonusPoints} points");
        }
        else if (_amountCompleted < _targetAmount)
        {
            Console.WriteLine($"I've logged that you did '{_goalName}' and got another {_pointsEarned} points. You are {_amountCompleted}/{_targetAmount} complete.");
        }
        return pointsGained;
    }

    public override string GetDetails()
    {
        string status = (_amountCompleted == _targetAmount) ? "[X]" : "[ ]";
        return $"{status} {_goalName} ({_description}) -- you have gotten done: {_amountCompleted}/{_targetAmount}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_goalName},{_description},{_pointsEarned},{_targetAmount},{_bonusPoints},{_amountCompleted}";
    }

    public bool IsComplete()
    {
        return _amountCompleted == _targetAmount;
    }
}