// I made sure to make it so eternal goals don't ever get completed. they only earn points
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }
    public EternalGoal(string name, string description, int points, int dummyParam = 0) : base(name, description, points)
    {
    }

    public override int RecordGoal()
    {
        Console.WriteLine($"I've logged that you did '{_goalName}' and got {_pointsEarned} points.");
        return _pointsEarned;
    }

    public override string GetDetails()
    {
        return $"[ ] {_goalName} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_goalName},{_description},{_pointsEarned}";
    }
}