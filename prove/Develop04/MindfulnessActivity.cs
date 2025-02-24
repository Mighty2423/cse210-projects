<<<<<<< HEAD

=======
>>>>>>> 8a7700f4d3f20f52e8fd13d484313d2bb6ee8b1f
public class MindfulnessActivity
{
    private int _duration;
    private string _name;
    
    public MindfulnessActivity(string name)
    {
        _name = name;
    }

    protected virtual string GetInstructions()
    {
        return "Follow the activity prompts to relax and reflect.";
    }

    public void Startactvity()
    {
        Console.Clear();

        // 🚀 Display loading screen & instructions first
        DisplayLoadingScreen();

        Console.Write("Enter duration in Seconds: ");
        _duration = int.Parse(Console.ReadLine());  // Now user enters duration

        Console.WriteLine("Switching to selected activity now...");
        Console.WriteLine("\nGet ready...");
    }
    
    public void StopActivity()
    {
        Console.WriteLine("Stopping activity: " + _name);
        Console.WriteLine($"Activity: {_name} | Duration: {_duration} seconds");
        PauseAnimation(1);
        return;

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

        Console.WriteLine($"\n Instructions for {_name} Activity:");
        Console.WriteLine(GetInstructions()); // 🚀 Show instructions correctly

        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine(); // Pause for user to read before moving on
    }


    public void PauseAnimation(int _seconds)
    {
        string[] _spinner = { "|", "/", "-", "\\" };
        int _time = 0;

        while (_time < _seconds)
        {
            foreach (string _frame in _spinner)
            {
                Console.Write($"\r{_frame} "); 
                Thread.Sleep(250);  // Pause for 250ms per frame
            }
            _time++;

            for (int i = 0; i < _seconds; i++)
            {
                foreach (string _frame in _spinner)
                {
                    Console.Write($"\r{_frame} "); // \r moves the cursor back to overwrite previous frame
                    Thread.Sleep(250);  // Pause for 250ms per frame
                }
                Console.Write("\r "); // Clear the animation
                Console.Write(".");
                Thread.Sleep(10);
            }
            Console.Write("\r "); // Clear the animation
            Console.WriteLine();
        }
    }

    public int GetDuration()
    {
        return _duration;
    }
<<<<<<< HEAD
    
    public void RunActivity()
    {
        // Implementation for RunActivity
        Console.WriteLine("Running activity: " + _name);
    }

}
=======
    public virtual void RunActivity()
    {}
}
>>>>>>> 8a7700f4d3f20f52e8fd13d484313d2bb6ee8b1f
