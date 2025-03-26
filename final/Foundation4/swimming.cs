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
        return GetDistance() / (time / 60.0); // speed in km/h
    }

    public override double GetPace()
    {
        return (time / 60.0) / GetDistance(); // pace in min/km
    }
}