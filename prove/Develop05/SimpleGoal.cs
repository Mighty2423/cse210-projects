public class SimpleGoal : Goal
{
    private bool completed;
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points) { completed = false; }
    public override void RecordProgress() { completed = true; }
    public override bool IsComplete() => completed;
    public override string GetSaveString() => $"SimpleGoal|{Name}|{Description}|{Points}|{completed}";
}
