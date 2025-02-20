public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity() : base("Breathing") { }

    protected override string GetInstructions()
    {
        return "Welcome to Breathing Activity. This activity will help you relax by focusing on your breathing. \n You will be asked to breathe in and out for a set amount of time you enter.";
    }

    public override void RunActivity()
    {
        Startactvity();
        int _duration = GetDuration();
        int _breathtime = 6;
        int _breaths = _duration / _breathtime;
        
        for (int i = 0; i < _breaths; i++)
        {
            Console.WriteLine("start");
            Console.WriteLine("Breathing in...");
            PauseAnimation(3);
            Console.WriteLine("Breathing out...");
            PauseAnimation(3);
        }
        StopActivity();
    }
}