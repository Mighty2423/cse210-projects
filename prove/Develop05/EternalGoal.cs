public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override string GetSaveString()
    {
        return $"EternalGoal|{Name}|{Description}|{EarnedPoints}";
    }

    public override void RecordProgress()
    {
        EarnedPoints += 5; // Example: Gain points every time you progress
    }

    public override bool IsComplete() => false; // Eternal goals never complete

    public override void LoadState(string[] parts)
    {
        base.LoadState(parts);
    }
}
