public class MindfulnessActivity
{
    protected int _duration;
    protected string _name;

    protected virtual string GetInstructions()
    {
        return $"Welcome to {_name} Activity.";
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

        Console.WriteLine("\nActivity Loaded Successfully!");
        Thread.Sleep(1000); // Give user a moment to see this before clearing
        Console.Clear(); // NOW clear the screen before showing instructions
        Console.WriteLine($"\n\n Welcome to \"{_name}\" activity in the Mindfulness Program");
        Console.WriteLine(GetInstructions()); // Show instructions correctly
        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine(); // Pause for user to read before moving on
         // Ensure a fresh start before asking for input
    }


    public void StartActivity()
    {
        // Display loading screen & instructions first
        DisplayLoadingScreen();
        while (true)
        {
            Console.Write("Enter duration in seconds: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out _duration) && _duration > 0) break;
            Console.WriteLine("⚠️ Invalid input! Please enter a valid positive number.");
        }
        Console.Clear();
        Console.WriteLine($"Switching to {_name} activity now...");
        PauseAnimation(2);
        Console.Clear();
        Console.WriteLine("\nGet ready...");
    }


    public void StopActivity()
    {
        Console.WriteLine($"\nStopping {_name} Activity...");
        Console.WriteLine($"Activity: {_name} | Duration: {_duration} seconds");
        Console.WriteLine("You have completed the activity");
        Console.WriteLine("Nice job!");
        PauseAnimation(5);
        return;
    }

    public void PauseAnimation(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        for (int i = 0; i < seconds * 4; i++) // 4 frames per second
        {
            Console.Write($"\r{spinner[i % 4]} ");
            Thread.Sleep(250);
        }
        Console.Write("\r   \n"); 
        Console.WriteLine();
    }

    public int GetDuration()
    {
        return _duration;
    }
    public virtual void RunActivity()
    {}
}
