using System;

class Program
{
    static void Main()
    {
        QuestManager questManager = new QuestManager();

        // Sample Goals
        questManager.AddGoal(new SimpleGoal("Run Marathon", "Complete a marathon", 1000));
        questManager.AddGoal(new EternalGoal("Scripture Study", "Read scriptures daily", 100));
        questManager.AddGoal(new ChecklistGoal("Temple Attendance", "Attend 10 times", 50, 10, 500));

        while (true)
        {
            Console.WriteLine("1. Show Goals");
            Console.WriteLine("2.Record Goal");
            Console.WriteLine("3.Show Score");
            Console.WriteLine("4.Exit");
            Console.Write("Enter choice: ");
            string input = Console.ReadLine();
            
            if (input == "1")
            {
                questManager.DisplayGoals();
            }
            else if (input == "2")
            {
                Console.Write("Enter goal name: ");
                string goalName = Console.ReadLine();
                questManager.RecordGoal(goalName);
            }
            else if (input == "3")
            {
                questManager.ShowScore();
            }
            else if (input == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice, try again.");
            }
        }
    }
}
