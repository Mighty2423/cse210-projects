public class SimpleGoal : Goal
{
    // Add isComplete field
    private bool isComplete;

    //simple goal constructor
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        isComplete = false;
    }

    // Add GetSaveString() method to be overridden
    public override string GetSaveString()
    {
        return $"SimpleGoal|{Name}|{Description}|{EarnedPoints}|{isComplete}";
    }

    // Add RecordProgress() method to be overridden
    public override void RecordProgress()
    {
        if (!isComplete)
        {
            isComplete = true;
            EarnedPoints += 10; // Example: Earn 10 points when completed
        }
    }

    // Add IsComplete() method to be overridden
    public override bool IsComplete() => isComplete;

    // Add LoadState() method to be overridden
    public override void LoadState(string[] parts)
    {
        base.LoadState(parts);
        if (parts.Length > 4)
        {
            isComplete = bool.Parse(parts[4]); // Restore completion status
        }
    }
}
