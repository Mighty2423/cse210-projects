// Reflect on past experiences to help you recognize the power you have and how you can use it in other aspects of your life.
// Create a ReflectionActivity class that is a subclass of the MindfulnessActivity class.
public class ReflectionActivity : MindfulnessActivity
{
    // private fields
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectionActivity() : base("Reflection")
    {
        // Initialize prompts and questions
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
            "Think of a time when you were really proud of yourself.",
            "Think of a time when you did a good deed."

        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

        // GetInstructions method
        protected override string GetInstructions()
    {
        return
        "This activity will help you reflect on times in your life when you have shown strength and resilience.\n" +
        "This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    // RunActivity method to run the reflection activity
    public override void RunActivity()
    {
        StartActivity();
        PauseAnimation(3);

        // Get the duration of the activity
        int _duration = GetDuration();
        Random random = new Random();

        // Display a prompt
        string _prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(_prompt);
        PauseAnimation(5);
        Console.WriteLine("Now think about the following questions:");
        PauseAnimation(3);
        
        // Display a question in loop
        int _holdtime = 0;
        while (_holdtime < _duration)
        {
            string _question = _questions[random.Next(_questions.Count)];
            Console.WriteLine(_question);
            PauseWithSpinner(5);
            _holdtime += 5;
        }
        StopActivity();
        PauseAnimation(5);
    }

    // PauseWithSpinner method to display a spinner animation for a given number of seconds
    private void PauseWithSpinner(int seconds)
    {
        // Spinner animation
        string[] spinner = { "|", "/", "-", "\\" };
        for (int i = 0; i < seconds * 4; i++) // 4 frames per second
        {
            Console.Write($"\r{spinner[i % 4]} ");
            Thread.Sleep(250);
        }
        // Clear spinner after animation
        Console.Write("\r   \n"); // Clear spinner after animation
    }
}