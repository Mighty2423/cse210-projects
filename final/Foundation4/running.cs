
// Running class
class Running : Activity
{
    // Fields
    // private distance in miles
    private double _distance; // in miles

    // Constructor
    // Initializes the date, time, and distance fields
    public Running(string date, int duration, double distance) : base(date, duration)
    {
        // Set the distance
        _distance = distance;
    }

    // Methods
    // Returns the distance of the activity in miles
    public override double GetDistance()
    {
        return _distance;
    }

    // Returns the speed of the activity in mph
    public override double GetSpeed()
    {
        return _distance / GetDuration() * 60; // Speed in mph
    }

    // Returns the pace of the activity in min/mile
    public override double GetPace()
    {
        return GetDuration() / _distance;
    }

    // Returns a summary of the activity
    //that overrides the GetSummaryOfActivity method in the base class
    public override string GetSummaryOfActivity()
    {
        return $"Time length: {GetDuration()} minutes - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min/mile";
    }
}