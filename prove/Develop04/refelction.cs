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
        return "Welcome to Reflection Activity.";
    }
    public override void RunActivity()
    {
        
        Startactvity();
        int _duration = GetDuration();
        Random random = new Random();

        string _prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(_prompt);
<<<<<<< HEAD
        PauseAnimation(5);
=======
        PauseAnimation(3);
        Console.WriteLine("Activity: Reflection");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you think about a time when you did something good for someone else.");
        Console.WriteLine("You will then answer some questions about that experience.");
        Console.WriteLine(_prompts[Random.Next(0, _prompts.Count)]);
        Console.WriteLine(_questions[Random.Next(0, _questions.Count)]);
        
>>>>>>> 2a5b402b88d0504e01622d097d6b89004307e095

        int _holdtime = 0;
        while (_holdtime < _duration)
        {
            string _question = _questions[random.Next(_questions.Count)];
            Console.WriteLine(_question);
            PauseAnimation(5);
            _holdtime += 5;
        }
        StopActivity();
    }
}