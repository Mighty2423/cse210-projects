public class SimpleGoal : Goal
{
    private bool _completed;

    public SimpleGoal(string _name, string _description, int _points) 
        : base(_name, _description, _points)
    {
        _completed = false;
    }

    public override void RecordProgress()
    {
        if (!_completed)
        {
        _completed = true;
        Console.WriteLine($"Goal {Name} completed! You earned {Points} points.");
        }
        else
        {
            Console.WriteLine($"Goal {Name} already completed.");
        }
    }

    public override bool IsComplete()
    {
        return _completed;
    }
}