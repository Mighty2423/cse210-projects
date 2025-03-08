public abstract class Goal
{
    public string Name { get; }
    public string Description { get; }
    public int Points { get; protected set; }

    public Goal(string _name, string _description, int _points)
    {
        Name = _name;
        Description = _description;
        Points = _points;
    }

    public abstract void RecordProgress();

    public abstract bool IsComplete();
}