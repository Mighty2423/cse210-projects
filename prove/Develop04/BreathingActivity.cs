// Purpose: Contains the BreathingActivity class which is a subclass of the 
// MindfulnessActivity class. This class is used to create a BreathingActivity
//  object which is used to run a breathing activity. The RunActivity method is 
// overridden to run the breathing activity. 
// The ShowCountdown method is used to display a countdown to the user. 
// The GetInstructions method is overridden to return the instructions for the 
// breathing activity. The BreathingActivity constructor is used to set the name 
// of the activity to "Breathing".
public class BreathingActivity : MindfulnessActivity
{
    //constructor BreathingActivity
    public BreathingActivity() : base("Breathing") { }

    //GetInstructions method
    protected override string GetInstructions()
    {
        return
        "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.\n" + 
        "You will be breathing in and out for a set amount of time.\n" + 
        "please enter the amount of time you would like to do this activity for in seconds.";
    }

    //RunActivity method breating in and out
    public override void RunActivity()
    {
        StartActivity();
        ShowCountdown(3);

        // Breathing in and out for the duration
        int _duration = GetDuration();
        int _breathing = 6;
        int _cycles = _duration / _breathing;

        // Breathing in and out for the cycles
        for (int i = 0; i < _cycles; i++)
        {
            Console.WriteLine("Breathing in...");
            ShowCountdown(3);

            Console.WriteLine("Now Breath out...");
            ShowCountdown(3);
        }
        StopActivity();
        PauseAnimation(5);
        }

        //ShowCountdown method
        private void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\r{i}... "); // \r moves the cursor back to overwrite previous number
            Thread.Sleep(1000);
        }
        Console.WriteLine("\r   \n"); // Clear line
    }
}