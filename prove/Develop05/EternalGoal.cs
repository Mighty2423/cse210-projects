public class EternalGoal : Goal
{
    private int _count;

    public EternalGoal(string name, string description, int points) 
        : base(name, description, points)
    {
        _count = 0;
    }



}