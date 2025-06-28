//this sets up the base class for "goals" in general so that the derived class have something to build off of.
public abstract class Goal
{
    protected string _goalName;
    protected string _description;
    protected int _pointsEarned;

    public Goal(string name, string description, int points)
    {
        _goalName = name;
        _description = description;
        _pointsEarned = points;
    }
//all goals have a name
    public string GetName()
    {
        return _goalName;
    }
//all goals have a description
    public string GetDescription()
    {
        return _description;
    }
//all goals have points
    public int GetPoints()
    {
        return _pointsEarned;
    }
    public abstract int RecordGoal();
    public abstract string GetDetails();
    public abstract string GetStringRepresentation();
    public void DisplayYourGoal()
    {
        Console.WriteLine($"{_goalName} - {_description}");
    }
}