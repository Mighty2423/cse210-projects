using System;
using System.Collections.Generic;
using System.IO;
namespace JournalProgram
{
    // Program Class: Handles the main menu and user interaction
    public class Program
    {
        private static bool _isRunning;

        static void Main(string[] args)
        {
            Journal journal = new Journal();
            _isRunning = true;

            while (_isRunning) 
            {
                Console.WriteLine("\nJournal Program");
                Console.WriteLine("1. Write Entry");
                Console.WriteLine("2. Display Entries from file");
                Console.WriteLine("3. Load file");
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
                        Entry entry = new Entry(); // Create an Entry object
                        journal.SaveEntries(entry);
                        break;

                    case "5":
                        _isRunning = false;
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

