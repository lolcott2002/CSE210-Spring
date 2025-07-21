using System;
using System.Collections.Generic;
public class Activity
{
    private DateTime _date;
    private int _lengthMinutes; 

    //general for all activities
    public Activity(DateTime date, int lengthMinutes)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public int GetLengthMinutes()
    {
        return _lengthMinutes;
    }

    //sets up a way to get the distance, but we can modify it for each class
    public virtual double GetDistance()
    {
        return 0.0;
    }
    //this is the speed
    public virtual double GetSpeed()
    {
        double distance = GetDistance();
        if (_lengthMinutes == 0 || distance == 0)
        {
            return 0.0;
        }
        return (distance / _lengthMinutes) * 60;
    }

    // this is the pace (I put an If statement in there to avoid errors from dividing by zero)
    public virtual double GetPace()
    {
        double distance = GetDistance();
        if (distance == 0)
        {
            return 0.0;
        }
        return (double)_lengthMinutes / distance;
    }

    //summary of each activity
    public virtual string GetWorkoutSummary()
    {
        return $"on {_date.ToString("MMM dd yyyy")} you did this activity for ({_lengthMinutes} minutes)";
    }
}

