public abstract class Goal
{
    public string Name { get; }
    public string Description { get; }
    public int Points { get; protected set; }

    public Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
    }

    
}