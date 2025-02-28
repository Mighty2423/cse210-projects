// MindfulnessActivity class
// Purpose: Contains the MindfulnessActivity class which is used to create a
// MindfulnessActivity object which is used to run a mindfulness activity. The
// MindfulnessActivity class contains the protected fields _duration and _name.
// The GetInstructions method is used to return the instructions for the activity.
// The DisplayLoadingScreen method is used to display a loading screen to the user.
// The StartActivity method is used to start the activity. The StopActivity method
// is used to stop the activity. The PauseAnimation method is used to display a
// spinner animation for a given number of seconds. The GetDuration method is used
// to return the duration of the activity. The RunActivity method is used to run the
// activity.
public class MindfulnessActivity
{
    //protectes fields
    protected int _duration;
    protected string _name;

    protected virtual string GetInstructions()
    {
        return $"Welcome to {_name} Activity.";
    }

    //constructor MindfulnessActivity with string name
    public MindfulnessActivity(string name)
    {
        _name = name;
    }

    //DisplayLoadingScreen method
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

    //StartActivity method
    public void StartActivity()
    {
        // Display loading screen & instructions first
        DisplayLoadingScreen();
        while (true)
        {
            // Get user input for duration
            Console.Write("Enter duration in seconds: ");
            string input = Console.ReadLine();
            // Validate input
            if (int.TryParse(input, out _duration) && _duration > 0) break;
            Console.WriteLine(" Invalid input! Please enter a valid positive number.");
        }
        // Clear screen before starting activity
        Console.Clear();
        Console.WriteLine($"Switching to {_name} activity now...");
        PauseAnimation(2);
        Console.Clear();
        Console.WriteLine("\nGet ready...");
    }

    //StopActivity method
    public void StopActivity()
    {
        Console.WriteLine($"\nStopping {_name} Activity...");
        Console.WriteLine($"Activity: {_name} | Duration: {_duration} seconds");
        Console.WriteLine("You have completed the activity");
        Console.WriteLine("Nice job!");
        PauseAnimation(5);
        return;
    }

    //PauseAnimation method
    public void PauseAnimation(int seconds)
    {
        // Display a spinner animation for a given number of seconds
        string[] spinner = { "|", "/", "-", "\\" };
        for (int i = 0; i < seconds * 4; i++) // 4 frames per second
        {
            Console.Write($"\r{spinner[i % 4]} ");
            Thread.Sleep(250);
        }
        // Clear spinner after animation
        Console.Write("\r   \n"); 
        Console.WriteLine();
    }

    //GetDuration method
    public int GetDuration()
    {
        return _duration;
    }

    //RunActivity method
    public virtual void RunActivity()
    {}
}
