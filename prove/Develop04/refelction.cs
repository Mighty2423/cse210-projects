public class ReflectionActivity : MindfulnessActivity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectionActivity() : base("Reflection")
    {
        _prompts = new List<string>();
        {

        };

        _questions = new List<string>
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