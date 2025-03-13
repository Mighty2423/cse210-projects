class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override void RecordProgress()
    {
        // Eternal goals never complete, but they always reward points
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetSaveString()
    {
        return $"EternalGoal|{Name}|{Description}|{Points}";
    }
}