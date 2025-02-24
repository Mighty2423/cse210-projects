public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity() : base("Breathing") { }

    protected override string GetInstructions()
    {
        return
        "in this activity you will be focusing on your breathing.\n" + 
        "You will be breathing in and out for a set amount of time.\n" + 
        "please enter the amount of time you would like to do this activity for in seconds.";
    }
    public override void RunActivity()
    {
        Startactvity();
        PauseAnimation(3);

        int duration = GetDuration();
        
        
        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine("Breathing in...");
            PauseAnimation(3);
            Console.WriteLine("Now Breath out...");
            PauseAnimation(3);
        }
        StopActivity();
        }

    }