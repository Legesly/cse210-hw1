using System;

public class Swimming : Activity
{
    private int _laps;
    private const double _lapLengthMeters = 50.0;

    public Swimming(DateTime date, int lengthMinutes, int laps)
        : base(date, lengthMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        double meters = _laps * _lapLengthMeters;
        return meters / 1000.0;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetLengthMinutes()) * 60.0;
    }

    public override double GetPace()
    {
        return GetLengthMinutes() / GetDistance();
    }
}
