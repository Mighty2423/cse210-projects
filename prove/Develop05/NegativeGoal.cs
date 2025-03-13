public class NegativeGoal : Goal
{
    private int penalty;

    public NegativeGoal(string name, string description, int points, int penalty) : base(name, description, points)
    {
        this.penalty = penalty;
    }

    public override string GetSaveString()
    {
        return $"NegativeGoal|{Name}|{Description}|{EarnedPoints}|{penalty}";
    }

    public override void RecordProgress()
    {
        EarnedPoints -= penalty; // Example: Lose points when triggered
    }

    public override bool IsComplete() => false; // Never "complete" in traditional sense

    public override void LoadState(string[] parts)
    {
        base.LoadState(parts);
        if (parts.Length > 4)
        {
            penalty = int.Parse(parts[4]); // Restore penalty value
        }
    }
}

