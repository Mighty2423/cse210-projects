public abstract class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int EarnedPoints { get; protected set; }

    public Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        EarnedPoints = points;
    }

    public abstract string GetSaveString();
    public abstract void RecordProgress();
    public abstract bool IsComplete();

    // Add LoadState() method to be overridden
    public virtual void LoadState(string[] parts)
    {
        if (parts.Length > 3)
        {
            EarnedPoints = int.Parse(parts[3]); // Restore earned points
        }
    }
}
