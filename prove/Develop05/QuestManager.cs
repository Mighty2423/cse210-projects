using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class QuestManager
{
    private List<Goal> _goals;
    private int _totalScore;
    private const string SaveFile = "goals.json";

    public QuestManager()
    {
        _goals = new List<Goal>();
        _totalScore = 0;
        LoadGoals();
    }

    public void AddGoal(Goal _goal)
    {
        _goals.Add(_goal);
        SaveGoals();
    }

    public void DisplayGoals()
    {
        Console.WriteLine(" Your Goals:");
        foreach (Goal goal in _goals)
        {
            string status = goal.IsComplete() ? "[X]" : "[ ]";
            Console.WriteLine($"- {status} {goal.Name}: {goal.Description}");
        }
    }

    public void RecordGoal(string _goalName)
    {
        Goal goal = _goals.Find(g => g.Name == _goalName);
        if (goal == null)
        {
           goal.RecordProgress();
           _totalScore += goal.Points;
            SaveGoals();
            Console.WriteLine($"Progress recorded for '{_goalName}'! You earned {goal.Points} points.");
        }
        else
        {
            Console.WriteLine("Goal not found.");
        }
    }

    public void ShowScore()
    {
        Console.WriteLine($"Your total score is {_totalScore} points.");
    }

    private void SaveGoals()
    {
        var saveData = new SaveData() { Goals = _goals, TotalScore = _totalScore };
        string json = JsonSerializer.Serialize(saveData, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(SaveFile, json);
        
    }

    private void LoadGoals()
    {
        if (File.Exists(SaveFile))
        {
            string json = File.ReadAllText(SaveFile);
            var saveData = JsonSerializer.Deserialize<SaveData>(json);
            if (saveData != null)
            {
                _goals = saveData.Goals;
                _totalScore = saveData.TotalScore;
            }
        }
    }

    private class SaveData
    {
        public List<Goal> Goals = new List<Goal>();
        public int TotalScore;
    }


    
}