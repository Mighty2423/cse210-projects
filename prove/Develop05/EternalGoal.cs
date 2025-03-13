public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override void RecordProgress() { }
    public override bool IsComplete() => false;
    public override string GetSaveString() => $"EternalGoal|{Name}|{Description}|{Points}";
}