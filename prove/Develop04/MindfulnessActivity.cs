public class MindfulnessActivity
{
    private int _duration;
    private string _name;

    protected virtual string GetInstructions()
    {
        return "Welcome to _name Activity.";
    }
    
    public MindfulnessActivity(string name)
    {
        _name = name;
    }

    protected void DisplayLoadingScreen()
    {
        Console.Clear();
        Console.Write($"Loading {_name} Activity");

        for (int i = 0; i < 3; i++)
        {
            Thread.Sleep(500);
            Console.Write(".");
        }

        Console.WriteLine("\n\nActivity Loaded Successfully!");
        Thread.Sleep(1000); // Give user a moment to see this before clearing
        Console.Clear(); // NOW clear the screen before showing instructions
        Console.WriteLine($"\n\n Welcome to \"{_name}\" activity in the Mindfulness Program");
        Console.WriteLine(GetInstructions()); // Show instructions correctly
        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine(); // Pause for user to read before moving on
         // Ensure a fresh start before asking for input
    }


    public void  Startactvity()
    {
        // Display loading screen & instructions first
        DisplayLoadingScreen();
        Console.Write("Enter duration in Seconds: ");
        _duration = int.Parse(Console.ReadLine());  // User enters duration
        Console.Clear();
        Console.WriteLine($"Switching to {_name} activity now...");
        PauseAnimation(2);
        Console.Clear();
        Console.WriteLine("\nGet ready...");
        PauseAnimation(2);
    }


    public void StopActivity()
    {
        Console.WriteLine("Stopping activity: " + _name);
        Console.WriteLine($"Activity: {_name} | Duration: {_duration} seconds");
        Console.WriteLine("You have completed the activity");
        Console.WriteLine("Nice job!");
        PauseAnimation(5);
        return;
    }

    public void PauseAnimation(int _seconds)
    {
        string[] _spinner = { "|", "/", "-", "\\" };

        for (int _time = 0; _time < _seconds * 4; _time++) // Run for total duration
        {
            Console.Write($"\r{_spinner[_time % 4]} "); // Overwrite previous frame
            Thread.Sleep(250); // 4 frames per second
        }

        Console.Write("\r "); // Clear spinner after animation
        Console.WriteLine();
    }

    public int GetDuration()
    {
        return _duration;
    }
    public virtual void RunActivity()
    {}
}
