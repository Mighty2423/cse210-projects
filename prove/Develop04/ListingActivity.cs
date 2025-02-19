public class ListingActivity : MindfulnessActivity
{
    private List<string> _prompts;
    private List<string> _responses;

    public ListingActivity() : base("Listing")
    {
        _prompts = new List<string>
        {

        };

        _responses = new List<string>();
        {
            
        };
    }
    public override void RunActivity()
    {
        Startactvity();
        PauseAnimation(3);

        PauseAnimation(3);

        StopActivity();
    }
}