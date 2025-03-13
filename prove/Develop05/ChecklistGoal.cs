public class ChecklistGoal : Goal
{
    private int target;
    private int progress;

    public ChecklistGoal(string name, string description, int points, int target)
        : base(name, description, points)
    {
        this.target = target;
        progress = 0;
    }

    public override void RecordProgress()
    {
        progress++;
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
        return $"ChecklistGoal|{Name}|{Description}|{Points}|{target}|{progress}";
    }
}