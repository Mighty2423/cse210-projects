class Cycling : Activity
{
    // Fields
    // private speed
    private double _speed; // mph

    // Constructor
    // Initializes the date, time, and speed fields
    public Cycling(string date, int time, double speed) : base(date, time)
    {
        // Set the speed
        _speed = speed;
    }

    // Methods
    // Returns the speed of the activity in mph
    public override double GetSpeed()
    {
        return _speed;
    }

    // Returns the pace of the activity in min/mile
    public override double GetPace() 
    {
        return 60 / _speed;
    }

    // Returns the distance of the activity in miles
    // that overrides the GetDistance method in the base class
    public override double GetDistance()
    {
        return _speed * (_time / 60.0); // Use _time from base class
    }

    // Returns a summary of the activity
    // that overrides the GetSummaryOfActivity method in the base class
    // As cycling summary is different from the base class, we override it
    public override string GetSummaryOfActivity()
    {
        return $"Time length: {_time} minutes - Distance: {GetDistance():0.##} miles, Speed: {GetSpeed()} mph, Pace: {GetPace():0.##} min/mile";
    }
}
