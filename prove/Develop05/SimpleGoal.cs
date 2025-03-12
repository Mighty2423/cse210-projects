public class SimpleGoal : Goal
{
    public bool Completed { get; private set; }

    public SimpleGoal(string _name, string _description, int _points) 
        : base(_name, _description, _points)
    {
        Completed = false;
    }

    public override void RecordProgress()
    {
        if (!Completed)
        {
        Completed = true;
        Console.WriteLine($"Goal {Name} completed! You earned {Points} points.");
        }
        else
        {
            Console.WriteLine($"Goal {Name} already completed.");
        }
    }

    public override bool IsComplete() => Completed;
}