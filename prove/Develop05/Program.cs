class Program
{
    static void Main()
    {
        QuestManager questManager = new QuestManager();
        questManager.LoadGoals();

        while (true)
        {
            Console.WriteLine("1. Add Goal");
            Console.WriteLine("2. Record Progress");
            Console.WriteLine("3. Show Goals");
            Console.WriteLine("4. Save & Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Goal Name: ");
                string name = Console.ReadLine();
                Console.Write("Description: ");
                string desc = Console.ReadLine();
                Console.Write("Points: ");
                int points = int.Parse(Console.ReadLine());
                Console.WriteLine("Select type: (1) Simple (2) Eternal (3) Checklist");
                int type = int.Parse(Console.ReadLine());

                if (type == 1)
                    questManager.AddGoal(new SimpleGoal(name, desc, points));
                else if (type == 2)
                    questManager.AddGoal(new EternalGoal(name, desc, points));
                else if (type == 3)
                {
                    Console.Write("Target count: ");
                    int target = int.Parse(Console.ReadLine());
                    questManager.AddGoal(new ChecklistGoal(name, desc, points, target));
                }
            }
            else if (choice == "2")
            {
                Console.Write("Enter goal name to record progress: ");
                string goalName = Console.ReadLine();
                questManager.RecordEvent(goalName);
            }
            else if (choice == "3")
            {
                questManager.DisplayGoals();
            }
            else if (choice == "4")
            {
                questManager.SaveGoals();
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice, try again.");
            }
        }
    }
}
