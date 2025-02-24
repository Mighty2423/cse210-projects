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

    protected override string GetInstructions()
    {
        return
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area. \n" +
        "Please enter the amount of time you would like to do this activity for in seconds.";
    }
    public override void RunActivity()
    {
        Startactvity();
        PauseAnimation(2);
        
        int _duration = GetDuration();
        Random random = new Random();

        string _prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(_prompt);
        PauseAnimation(5);

        DateTime _end = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < _end)
        {
            Console.WriteLine("Please enter your response: ");
            string _response = Console.ReadLine();
            _responses.Add(_response);
        }
        Console.WriteLine("Time is up!");
        Console.WriteLine($"You entered this many {_responses.Count} items.");
        Console.WriteLine("Nice job!");
        Console.Clear();
        PauseAnimation(5);
        StopActivity();
    }
}