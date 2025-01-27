using System;
using System.Collections.Generic;
namespace JournalProgram
{
    // Program Class: Handles the main menu and user interaction
    public class Program
    {
        private static bool isRunning;

        static void Main(string[] args)
        {
            Journal journal = new Journal();
            

            while (true) 
            {
                Console.WriteLine("\nJournal Program");
                Console.WriteLine("1. Write Entry");
                Console.WriteLine("2. Display Entries");
                Console.WriteLine("3. Load Entries");
                Console.WriteLine("4. Save Entries");
                Console.WriteLine("5. Quit");
                Console.Write("Select an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        journal.WriteEntry();
                        break;
                    case "2":
                        journal.DisplayEntries();
                        break;
                    case "3":
                        journal.LoadEntries();
                        break;
                    case "4":
                        journal.SaveEntries();
                        break;
                    case "5":
                        "5" = false;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}