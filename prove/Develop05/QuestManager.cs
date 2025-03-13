

public class QuestManager
{
    private List<Goal> goals = new List<Goal>();
    private int points = 0;
    private string filePath = "goals.txt";

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(points); // ✅ Save points to file

            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.GetSaveString());
            }
        }
        Console.WriteLine("Goals saved successfully!");
    }


    public void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            goals.Clear();
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                points = int.Parse(reader.ReadLine());

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    Goal goal = null;

                    if (parts[0] == "SimpleGoal")
                    {
                        goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                        if (bool.Parse(parts[4])) ((SimpleGoal)goal).RecordProgress();
                    }
                    else if (parts[0] == "EternalGoal")
                    {
                        goal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                    }
                    else if (parts[0] == "NegativeGoal")
                    {
                        goal = new NegativeGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]));
                    }

                    if (goal != null)
                    {
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


    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        Goal goal = goals.Find(g => g.Name == goalName);
        if (goal != null)
        {
            goal.RecordProgress();
            points += goal.Points;

            if (goal.IsComplete())
            {
                Console.WriteLine($"Congratulations! '{goal.Name}' is complete. You earned {goal.Points} points!");
            }
            else
            {
                Console.WriteLine($"Progress recorded for '{goal.Name}'. You earned {goal.Points} points.");
            }
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
        for (int i = 0; i < goals.Count; i++)
        {
            Goal goal = goals[i];
            string status = goal.IsComplete() ? "[✓] Completed" : "[ ] In Progress";

            // Handle negative goals separately
            if (goal is NegativeGoal)
            {
                status = "[!] Negative Goal";
            }

            Console.WriteLine($"{i + 1}. {goal.Name} - {goal.Description} {status}");
        }
    }

    public int GetAccumulatedPoints()
    {
        int accumulatedPoints = 0;
        foreach (Goal goal in goals)
        {
            accumulatedPoints += goal.EarnedPoints;
        }
        return accumulatedPoints;
    }

    public int GetPoints()
    {
        return points;
    }

}
