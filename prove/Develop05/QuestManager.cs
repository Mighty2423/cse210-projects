using System;
using System.Collections.Generic;
using System.IO;

public class QuestManager
{
    private List<Goal> goals = new List<Goal>();
    private string filePath = "goals.txt"; // File path for saving goals

    public void SaveGoals()
    {
        List<string> lines = new List<string>();
        foreach (Goal goal in goals)
        {
            lines.Add(goal.GetSaveString());
        }
        File.WriteAllLines(filePath, lines);
    }

    public void LoadGoals()
    {
        if (!File.Exists(filePath))
            return;

        goals.Clear();

        string[] lines = File.ReadAllLines(filePath);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            string type = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            if (type == "SimpleGoal")
            {
                bool completed = bool.Parse(parts[4]);
                SimpleGoal goal = new SimpleGoal(name, description, points);
                if (completed)
                {
                    goal.RecordProgress();
                }
                goals.Add(goal);
            }
            else if (type == "EternalGoal")
            {
                goals.Add(new EternalGoal(name, description, points));
            }
            else if (type == "ChecklistGoal")
            {
                int target = int.Parse(parts[4]);
                int progress = int.Parse(parts[5]);
                ChecklistGoal goal = new ChecklistGoal(name, description, points, target);
                goal.SetProgress(progress);
                goals.Add(goal);
            }
        }
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        Goal goal = goals.Find(g => g.Name.Equals(goalName, StringComparison.OrdinalIgnoreCase));
        if (goal != null)
        {
            goal.RecordProgress();
            Console.WriteLine($"Progress recorded for '{goal.Name}'.");
        }
        else
        {
            Console.WriteLine("Goal not found.");
        }
    }

    public void DisplayGoals()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals available.");
            return;
        }

        foreach (Goal goal in goals)
        {
            Console.WriteLine($"{goal.Name} - {goal.Description} [{(goal.IsComplete() ? "Completed" : "In Progress")}]");
        }
    }
}
