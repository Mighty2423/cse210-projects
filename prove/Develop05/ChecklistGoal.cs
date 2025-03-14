public class ChecklistGoal : Goal
{
    private int target;
    private int progress;
    public int Points { get; set; }

    public ChecklistGoal(string name, string description, int points, int target)
        : base(name, description, points)
    {
        this.target = target;
        progress = 0;
    }

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




    public override bool IsComplete()
    {
        return progress >= target;
    }

    public void SetProgress(int value)
    {
        progress = value;
    }

    public override string GetSaveString()
    {
        return $"ChecklistGoal|{Name}|{Description}|{EarnedPoints}|{target}|{progress}";
    }

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
