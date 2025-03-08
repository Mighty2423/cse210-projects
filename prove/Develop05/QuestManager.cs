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

    public void AddGoal(Goal _goal)
    {
        _goals.Add(_goal);
    }

    public void DisplayGoals()
    {
        Console.WriteLine(" Your Goals:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"- {goal.Name}: {goal.Description}");
        }
    }

    public void RecordGoal(string _goalName)
    {
        
    }

    public void ShowScore()
    {
        Console.WriteLine($"Your total score is {_totalScore} points.");
    }

    private void SaveGoals()
    {
        
    }

    private void LoadGoals()
    {
        
    }

    private class SaveData
    {

    }


    
}