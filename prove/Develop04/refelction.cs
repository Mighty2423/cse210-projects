public class ReflectionActivity : MindfulnessActivity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectionActivity() : base("Reflection")
    {
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
        protected override string GetInstructions()
    {
        return
        "This activity will help you reflect on times in your life when you have shown strength and resilience.\n" +
        "This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }
    

    public override void RunActivity()
    {
        StartActivity();
        PauseAnimation(3);


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