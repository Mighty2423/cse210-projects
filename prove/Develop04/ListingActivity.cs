public class ListingActivity : MindfulnessActivity
{
    private List<string> _prompts;
    private List<string> _responses;

    public ListingActivity() : base("Listing")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        _responses = new List<string>();
        {
            
        };
    }
    public override void RunActivity()
    {
        Startactvity();
        PauseAnimation(3);
        Console. WriteLine("Activity: Listing");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        

        PauseAnimation(3);

        StopActivity();
    }
}