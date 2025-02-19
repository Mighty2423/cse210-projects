

using System.Diagnostics;

public class MindfulnessActivity
{
    private int _duration;
    private string _name;
    
    public MindfulnessActivity(string name)
    {
        _name = name;
    }

    public void Startactvity()
    {
        Console.Clear();
        Console.WriteLine("Starting activity: " + _name);
        Console.Write("Enter duration in Seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Switinf to selected activity now...");
        PauseAnimation(3);

        

    }

    public void StopActivity()
    {
        Console.WriteLine("Stopping activity: " + _name);
        Console.WriteLine($"Activity: {_name} | Duration: {_duration} seconds");
        PauseAnimation(3);

    }

    public void PauseAnimation(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public int GetDuration()
    {
        return _duration;
    }
    
    public void RunActivity()
    
}