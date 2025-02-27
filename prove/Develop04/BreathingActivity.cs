public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity() : base("Breathing") { }

    protected override string GetInstructions()
    {
        return
        "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.\n" + 
        "You will be breathing in and out for a set amount of time.\n" + 
        "please enter the amount of time you would like to do this activity for in seconds.";
    }
    public override void RunActivity()
    {
        Startactvity();
        ShowCountdown(3);

        int _duration = GetDuration();
        int _breathing = 6;
        int _cycles = _duration / _breathing;

        
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