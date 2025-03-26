class Swimming : Activity
{
    private int _laps;
    private const double LapLengthMeters = 50; // 50 meters per lap

    public Swimming(string date, int time, int laps) : base(date, time)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * LapLengthMeters / 1000.0; // distance in kilometers
    }

    public override double GetSpeed()
    {
        return GetDistance() / (GetTime() / 60.0); // speed in km/h
    }

    protected int GetTime()
    {
        return _time; // Assuming 'Time' is a property or field in the base class
    }

    public override double GetPace()
    {
        return GetTime() / 60.0 / GetDistance(); // pace in min/km
    }
}