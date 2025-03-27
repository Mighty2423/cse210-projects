public abstract class Activity
{
    // Fields
    // Time in minutes
    public int _time; // in minutes

    // Constructor
    // Initializes the date and time fields
    public Activity(string date, int time)
    {
        _time = time;
    }

    // Methods are abstract and must be implemented in derived classes
    // Returns the distance of the activity in miles
    public abstract double GetDistance(); // in miles
    // Returns the speed of the activity in mph
    public abstract double GetSpeed(); // in mph
    // Returns the pace of the activity in min/mile
    public abstract double GetPace(); // in min/mile

    // Returns the date of the activity in the format "YYYY-MM-DD"
    public int GetDuration()
    {
        return _time;
    }

    // Returns a summary of the activity
   public virtual string GetSummaryOfActivity()
    {
        return "Activity summary not available.";
    }

    // Returns the distance of the activity in kilometers just a personal try please ignore
    public double GetDistanceInKilometers()
    {
        double distanceInKilometers = GetDistance() * 1.60934; // Convert miles to kilometers
        double speedInKilometersPerHour = GetSpeed() * 1.60934; // Convert mph to km/h
        double paceInKilometersPerMinute = GetPace() * 1.60934; // Convert min/mile to min/km
        return distanceInKilometers;
    }
}