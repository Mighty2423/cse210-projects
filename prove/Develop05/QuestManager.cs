public class QuestManager
{
    private List<Goal> goals = new List<Goal>();
    private string filePath = "goals.txt";
    private static int totalPoints = 0;

    public void AddPoints(int pointsToAdd)
    {
        totalPoints += pointsToAdd;
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine(totalPoints); 
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.GetSaveString());
            }
        }
        Console.WriteLine("Goals saved successfully!");
        Console.WriteLine($"You have {totalPoints} points.\n");
    }

    public void LoadGoals()
    {
        if (File.Exists(filePath))
        {
            goals.Clear();
            using (StreamReader reader = new StreamReader(filePath))
            {
                totalPoints = int.Parse(reader.ReadLine()); // Restore total points

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    Goal goal = null;
                    if (parts[0] == "SimpleGoal")
                        goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                    else if (parts[0] == "EternalGoal")
                        goal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                    else if (parts[0] == "ChecklistGoal")
                        goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]));
                    else if (parts[0] == "NegativeGoal")
                        goal = new NegativeGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]));

                    if (goal != null)
                    {
                        goal.LoadState(parts);
                        goals.Add(goal);
                    }
                }
            }
            Console.WriteLine("Goals loaded successfully!");
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }

    public void AddGoal(Goal goal) => goals.Add(goal);

    public void RecordEvent(string goalName)
    {
        Goal goal = goals.Find(g => g.Name.ToLower() == goalName.ToLower());
        if (goal != null)
        {
            int previousPoints = totalPoints; // Store previous points before update
            goal.RecordProgress();
            totalPoints += goal.EarnedPoints; // Ensure points accumulate
            Console.WriteLine($"Progress recorded for '{goal.Name}'.");
            Console.WriteLine($"Points updated: {previousPoints} → {totalPoints}");
        }
        else
        {
            Console.WriteLine("Goal not found.");
        }
    }


    public void ListGoals()
    {
        if (goals.Count == 0)
        { 
            Console.WriteLine("No goals available.");
            return;
        }
        Console.WriteLine("Your Goals:");
        foreach (Goal goal in goals)
        {
            string status = goal.IsComplete() ? "[✓] Completed" : "[ ] In Progress";
            Console.WriteLine($"{goal.Name} - {goal.Description} {status}");
        }
        Console.WriteLine($"You have {totalPoints} points.");
    }

    public int GetAccumulatedPoints() => totalPoints;
}
