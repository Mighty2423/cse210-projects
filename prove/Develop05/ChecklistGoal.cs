public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _progress;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints) 
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _progress = 0;
    }



}