public abstract class Goal
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public int Points { get; protected set; }

    public Goal(string _name, string _description, int _points)
    {
        Name = _name;
        Description = _description;
        Points = _points;
    }

    public abstract void RecordProgress();
    public abstract bool IsComplete();

 public virtual void DisplayInfo()
    {
        Console.WriteLine($"🏆 {Name} - {Description} ({Points} pts)");
    }

    // (Optional) Returns earned points — useful for future extensions
    public virtual int EarnedPoints()
    {
        return Points;
    }
}