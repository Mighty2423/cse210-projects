public abstract class Activity
{
    private string _date;
    public int _time; // in minutes

    public Activity(string date, int time)
    {
        _date = date;
        _time = time;
    }

    public abstract double GetDistance(); // in miles
    public abstract double GetSpeed(); // in mph
    public abstract double GetPace(); // in min/mile

    public int GetDuration()
    {
        return _time;
    }

   public virtual string GetSummaryOfActivity()
    {
        return "Activity summary not available.";
    }
    public double GetDistanceInKilometers()
    {
        double distanceInKilometers = GetDistance() * 1.60934; // Convert miles to kilometers
        double speedInKilometersPerHour = GetSpeed() * 1.60934; // Convert mph to km/h
        double paceInKilometersPerMinute = GetPace() * 1.60934; // Convert min/mile to min/km
        return distanceInKilometers;
    }
}