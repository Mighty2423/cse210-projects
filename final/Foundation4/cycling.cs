
class Cycling : Activity
{
    private double _speed; // mph
    public int Time { get; set; }

    public Cycling(string date, int time, double speed) : base(date, time)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace() 
    {
        return 60 / _speed;
    }

    public override double GetDistance()
    {
        return _speed * (Time / 60.0);
    }
}