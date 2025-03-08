public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _progress;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints) 
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _progress = 0;
    }

    public override void RecordProgress()
    {
        _progress++;
        Console.WriteLine($"Progress: {_progress}/{_targetCount}");
        if (_progress == _targetCount)
        {
            Console.WriteLine($"Goal {Name} completed! You earned {Points + _bonusPoints} points.");
        }
        else
        {
            Console.WriteLine($"Goal {Name} progress: {_progress}/{_targetCount}. You earned {Points} points.");
        }
    }


    public override bool IsComplete() => _progress >= _targetCount;
}