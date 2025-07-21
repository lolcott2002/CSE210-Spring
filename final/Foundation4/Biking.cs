public class Cycling : Activity
{
    private double _speedMph; 

    public Cycling(DateTime date, int lengthMinutes, double speedMph)
        : base(date, lengthMinutes)
    {
        _speedMph = speedMph;
    }
    public override double GetSpeed()
    {
        return _speedMph;
    }
    //using speed and duration to calculate distance
    public override double GetDistance()
    {
        return (_speedMph * base.GetLengthMinutes()) / 60.0;
    }
    public override string GetWorkoutSummary()
    {
        return $"on {base.GetDate().ToString("MMM dd yyyy")} you went biking for ({base.GetLengthMinutes()} minutes): " +
               $"distance was {GetDistance():F1} miles, " +
               $"speed was {GetSpeed():F1} miles per hour, " +
               $"pace was {GetPace():F1} minutes per mile";
    }
}

