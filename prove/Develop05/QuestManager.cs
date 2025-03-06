public class QuestManager
{
    private List<Goal> _goals;
    private int _totalScore;
    private const string SaveFile = "goals.json";

    public QuestManager()
    {
        _goals = new List<Goal>();
        _totalScore = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayGoals()
    {
    
    }

    public void RecordGoal(string goalName)
    {
    
    }

    public void ShowScore()
    {
    
    }

    public void Save()
    {
    
    }

    public void Load()
    {
    
    }

    public void SaveToFile()
    {
    
    }

    public void LoadFromFile()
    {
    
    }

    
}