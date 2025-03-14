public class EternalGoal : Goal
{
    // Eternal goal constructor
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    // Add GetSaveString() method to be overridden
    public override string GetSaveString()
    {
        return $"EternalGoal|{Name}|{Description}|{EarnedPoints}";
    }

    // Add RecordProgress() method to be overridden
    public override void RecordProgress()
    {
        EarnedPoints += 5; // Example: Gain points every time you progress
    }

    // Add IsComplete() method to be overridden
    public override bool IsComplete() => false; // Eternal goals never complete

    // Add LoadState() method to be overridden
    public override void LoadState(string[] parts)
    {
        base.LoadState(parts);
    }
}
