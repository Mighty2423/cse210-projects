class Swimming : Activity
{
    // Fields
    // private laps
    private int _laps;
    // Lap length in meters
    private const double LapLengthMeters = 50; // 50 meters per lap

    // Constructor
    // Initializes the date, time, and laps fields
    public Swimming(string date, int time, int laps) : base(date, time)
    {
        _laps = laps;
    }

    // Returns the distance of the activity in kilometers
    // that overrides the GetDistance method in the base class
    public override double GetDistance()
    {
        return _laps * LapLengthMeters / 1000.0; // distance in kilometers
    }

    // Returns the speed of the activity in km/h
    public override double GetSpeed()
    {
        return GetDistance() / (GetTime() / 60.0); // speed in km/h
    }

    // Returns the time of the activity in minutes
    protected int GetTime()
    {
        return _time; // Assuming 'Time' is a property or field in the base class
    }

    // Returns the pace of the activity in min/km
    public override double GetPace()
    {
        return GetTime() / 60.0 / GetDistance(); // pace in min/km
    }

    // Returns a summary of the activity
    // that overrides the GetSummaryOfActivity method in the base class
    // As swimming summary is different from the base class, we override it
    public override string GetSummaryOfActivity()
    {
        return $"Time length: {GetTime()} minutes - Distance: {GetDistance()} km, Speed: {GetSpeed()} km/h, Pace: {GetPace()} min/km";
    }
}