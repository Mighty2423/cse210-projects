public class ChecklistGoal : Goal
{
    // Add target and progress fields
    private int target;
    private int progress;
    public int Points { get; set; }

    //checklist goal constructor
    public ChecklistGoal(string name, string description, int points, int target)
        : base(name, description, points)
    {
        this.target = target;
        progress = 0;
    }

    // Add GetSaveString() method to be overridden
    public override void RecordProgress()
    {
        if (progress < target)
        {
            progress++;
            EarnedPoints += Points;
            QuestManager manager = new QuestManager();
            manager.AddPoints(Points);
        }
    }

    // Add IsComplete() method to be overridden
    public override bool IsComplete()
    {
        return progress >= target;
    }

    // Add SetProgress() method
    public void SetProgress(int value)
    {
        progress = value;
    }

    // Add GetProgress() method
    public override string GetSaveString()
    {
        return $"ChecklistGoal|{Name}|{Description}|{EarnedPoints}|{target}|{progress}";
    }

    // Add LoadState() method to be overridden
    public override void LoadState(string[] parts)
    {
        base.LoadState(parts);
        if (parts.Length > 4)
        {
            target = int.Parse(parts[4]);   // Restore target count
            progress = int.Parse(parts[5]); // Restore progress count
        }
    }
}
