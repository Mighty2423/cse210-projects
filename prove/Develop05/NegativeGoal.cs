public class NegativeGoal : Goal
{
    // Add penalty field
    private int penalty;

    //negative goal constructor
    public NegativeGoal(string name, string description, int points, int penalty) : base(name, description, points)
    {
        this.penalty = penalty;
    }

    // Add GetSaveString() method to be overridden
    public override string GetSaveString()
    {
        return $"NegativeGoal|{Name}|{Description}|{EarnedPoints}|{penalty}";
    }

    // Add RecordProgress() method to be overridden
    public override void RecordProgress()
    {
        EarnedPoints -= penalty; // Example: Lose points when triggered
    }

    public override bool IsComplete() => false; // Never "complete" in traditional sense
    
    // Add LoadState() method to be overridden
    public override void LoadState(string[] parts)
    {
        base.LoadState(parts);
        if (parts.Length > 4)
        {
            penalty = int.Parse(parts[4]); // Restore penalty value
        }
    }
}

