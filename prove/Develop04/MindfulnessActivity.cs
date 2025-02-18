

using System.Diagnostics;

public class MindfulnessActivity
{
    private int _duration;
    private string _name;
    
    public MindfulnessActivity(string name, int duration)
    {
        _name = name;
        _duration = duration;
    }

    public Startactvity()
    {
        Console.WriteLine("Starting activity: " + _name);
    }

    public StopActivity()
    {
        Debug.WriteLine("Stopping activity: " + _name);
    }

    public displayspinner()
    {
        Debug.WriteLine("Displaying spinner for activity: " + _name);
    }

    public HideSpinner()
    {
        Debug.WriteLine("Hiding spinner for activity: " + _name);
    }
}