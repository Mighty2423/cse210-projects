using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string menuSelected = "";
        QuestManager goals = new QuestManager();

        while (menuSelected != "6")
        {
            int points = goals.GetAccumulatedPoints();
            Console.WriteLine("\nWelcome to the Quest Manager!");
            Console.WriteLine($"You have {points} points.\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            menuSelected = Console.ReadLine();

            switch (menuSelected)
            {
                case "1":
                    Console.WriteLine("\nThe Types of Goals are: ");
                    Console.WriteLine("  1. Simple Goal");
                    Console.WriteLine("  2. Eternal Goal");
                    Console.WriteLine("  3. Checklist Goal");
                    Console.WriteLine("  4. Negative Goal");
                    Console.Write("Which type of goal would you like to create? ");
                    string goalType = Console.ReadLine();

                    Console.Write("Goal Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Description: ");
                    string desc = Console.ReadLine();
                    Console.Write("Points: ");
                    int pointsValue = int.Parse(Console.ReadLine());

                    switch (goalType)
                    {
                        case "1":
                            goals.AddGoal(new SimpleGoal(name, desc, pointsValue));
                            break;
                        case "2":
                            goals.AddGoal(new EternalGoal(name, desc, pointsValue));
                            break;
                        case "3":
                            Console.Write("Target count: ");
                            int target = int.Parse(Console.ReadLine());
                            goals.AddGoal(new ChecklistGoal(name, desc, pointsValue, target));
                            break;
                        case "4":
                            Console.Write("Penalty: ");
                            int penalty = int.Parse(Console.ReadLine());
                            goals.AddGoal(new NegativeGoal(name, desc, pointsValue, penalty));
                            break;
                        default:
                            Console.WriteLine("Invalid goal type. Please try again.");
                            break;
                    }
                    break;
                case "2":
                    goals.ListGoals();
                    break;
                case "3":
                    goals.SaveGoals();
                    break;
                case "4":
                    goals.LoadGoals();
                    break;
                case "5":
                    Console.Write("Enter goal name to record progress: ");
                    string goalName = Console.ReadLine();
                    goals.RecordEvent(goalName);
                    Console.WriteLine($"You have {goals.GetAccumulatedPoints()} points.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Please select a valid number from the menu options.");
                    break;
            }
        }
    }
}