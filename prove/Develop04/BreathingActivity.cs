public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity() : base("Breathing") { }

    public override void RunActivity()
    {
        Startactvity();
        PauseAnimation(3);

        int duration = GetDuration();
        
        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine("Breathing in...");
            PauseAnimation(3);
            Console.WriteLine("Breathing out...");
            PauseAnimation(3);
        }

        StopActivity();

    }

}