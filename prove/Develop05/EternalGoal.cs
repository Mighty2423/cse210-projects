public class EternalGoal : Goal
{
    private int _count;

    public EternalGoal(string _name, string _description, int _points) 
        : base(_name, _description, _points)
    {
        _count = 0;
    }

    public override void RecordProgress()
    {
        _count++;
        Console.WriteLine($"Progress: {_count}");
        Console.WriteLine($"Goal {Name} progress: {_count}. You earned {Points} points.");
    }



    public override bool IsComplete() => false; //Never completes
}