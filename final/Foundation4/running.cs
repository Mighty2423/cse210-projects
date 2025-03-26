
class Running : Activity
{
    private double _distance; // in miles

    public Running(string date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / GetDuration() * 60; // Speed in mph
    }

    public override double GetPace()
    {
    return GetDuration() / _distance;
    }

    public override string GetSummaryOfActivity()
    {
        return $"Time length: {GetDuration()} minutes - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min/mile";
    }
}