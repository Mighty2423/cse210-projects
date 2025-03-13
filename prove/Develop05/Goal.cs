public abstract class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }
    public int EarnedPoints { get; protected set; }

    public Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
        EarnedPoints = 0;
    }

    public abstract void RecordProgress();
    public abstract bool IsComplete();
    public abstract string GetSaveString();
}