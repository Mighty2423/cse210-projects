public class SimpleGoal : Goal
{
    private bool isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        isComplete = false;
    }

    public override string GetSaveString()
    {
        return $"SimpleGoal|{Name}|{Description}|{EarnedPoints}|{isComplete}";
    }

    public override void RecordProgress()
    {
        if (!isComplete)
        {
            isComplete = true;
            EarnedPoints += 10; // Example: Earn 10 points when completed
        }
    }

    public override bool IsComplete() => isComplete;

    public override void LoadState(string[] parts)
    {
        base.LoadState(parts);
        if (parts.Length > 4)
        {
            isComplete = bool.Parse(parts[4]); // Restore completion status
        }
    }
}
