public class Running : Activity
{
    private double _distanceMiles; 
    public Running(DateTime date, int durationMinutes, double distanceMiles)
        : base(date, durationMinutes)
    {
        _distanceMiles = distanceMiles;
    }
    public override double GetDistance()
    {
        return _distanceMiles;
    }
    public override string GetWorkoutSummary()
    {
        return $"on {base.GetDate().ToString("MMM dd yyyy")} you went running for ({base.GetLengthMinutes()} minutes): " +
               $"distance {GetDistance():F1} miles, " +
               $"speed {GetSpeed():F1} miles per hour, " +
               $"pace: {GetPace():F1} min per mile";
    }
}
