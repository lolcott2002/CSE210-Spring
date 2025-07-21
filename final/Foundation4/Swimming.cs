public class Swimming : Activity
{
    private int _numberOfLaps;
    public Swimming(DateTime date, int durationMinutes, int numberOfLaps)
        : base(date, durationMinutes)
    {
        _numberOfLaps = numberOfLaps;
    }
    public override double GetDistance()
    {
        const double metersPerMile = 1609.34;
        return (_numberOfLaps * 50.0) / metersPerMile;
    }
    public override string GetWorkoutSummary()
    {
        return $"on {base.GetDate().ToString("MMM dd yyyy")} you went swimming for ({base.GetLengthMinutes()} minutes): " +
               $"distance {GetDistance():F1} miles, " +
               $"speed {GetSpeed():F1} mph, " +
               $"pace: {GetPace():F1} min per mile";
    }
}