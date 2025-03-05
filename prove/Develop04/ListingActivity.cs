// Purpose: Contains the ListingActivity class which is a subclass of the MindfulnessActivity class. 
// This class is used to create a ListingActivity object which is an activity that prompts the user to list as many items as they can in a certain area for a certain amount of time. 
// The user is prompted with a question and then has a certain amount of time to list as many items as they can. 
// The user's responses are stored in a list and then displayed at the end of the activity. 
// The ListingActivity class contains a constructor, a GetInstructions method, a RunActivity method, and a PauseWithSpinner method.
public class ListingActivity : MindfulnessActivity
{
    // private fields
    private List<string> _prompts;
    private List<string> _responses;

    // constructor ListingActivity
    public ListingActivity() : base("Listing")
    {
        // Initialize prompts
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        // Initialize responses
        _responses = new List<string>();
    }

    // GetInstructions method
    protected override string GetInstructions()
    {
        return
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area. \n" +
        "Please enter the amount of time you would like to do this activity for in seconds.";
    }

    // RunActivity method to run the listing activity
    public override void RunActivity()
    {
        StartActivity();
        
        int _duration = GetDuration();
        Random random = new Random();
        
        // Display a prompt to the user
        Console.Clear();
        string _prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(_prompt);
        Console.WriteLine("\nThink about it for a moment...");
        PauseWithSpinner(5);

        // Prompt the user to list as many items as they can
        Console.WriteLine("\nNow, start listing as many items as you can:");

        // Get the user's responses
        DateTime _end = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < _end)
        {
            Console.WriteLine("Please enter your response: ");
            string _response = Console.ReadLine();
            _responses.Add(_response);
        }
        // Display the user's responses
        if (_responses.Count == 0)
        {
            Console.WriteLine("You did not enter any items.");
        }
        else
        {
            // Display the user's responses
            Console.WriteLine("Time is up!");
            Console.WriteLine($"You entered this many {_responses.Count} responses.");
            Console.WriteLine("Nice job!");
        }
        PauseAnimation(5);
        StopActivity();
    }

    // PauseWithSpinner method to display a spinner animation for a given number of seconds
    private void PauseWithSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        for (int i = 0; i < seconds * 4; i++) // 4 frames per second
        {
            Console.Write($"\r{spinner[i % 4]} ");
            Thread.Sleep(250);
        }
        Console.Write("\r   \n"); // Clear spinner after animation
    }
}