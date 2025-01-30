using System;
using System.Collections.Generic;
using System.Security.Cryptography;

// Journal Class: Manages journal entries and operations
public class Journal
{
    private Repository _repository = new Repository();
    private Prompt _prompt = new Prompt();
    //works do not touch but may need too
    //write the entry
    public Entry WriteEntry()
    {
        Entry entry = new Entry();
        entry._date = DateTime.Now.ToString();
        entry._prompt = Prompt.GetPrompt();
        Console.WriteLine(entry._prompt);
        Console.WriteLine("Enter the content:");
        entry._content = Console.ReadLine();
        _repository.AddEntry(entry);
        Console.WriteLine("Entry saved.");
        return entry;
    }
     //fix with class and possibly here
     //display the entries
    public void DisplayEntries()
    {
        List<Entry> entries = _repository.GetEntries();
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries found. Try adding some!");
        }
        else
        {
            foreach (Entry entry in entries)
            {
                entry.Display();
                Console.WriteLine();
            }
        }


    }
    
    //works do not touch
    //load the entries
    public void LoadEntries()
    {
        Console.Write("Enter the file name to load entries (e.g., journal1.txt): ");
        string fileName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(fileName))
        {
            Console.WriteLine("Invalid file name. Using default 'example.txt'.");
            fileName = "example.txt";
        }

        if (!fileName.EndsWith(".txt"))
        {
            fileName += ".txt";
        }
    }
    //works do not touch
    //save the entries
    public void SaveEntries(Entry entry)
    {
        Console.Write("Enter the file name to save entries (e.g., journal1): ");
        string fileName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(fileName))
        {
            Console.WriteLine("Invalid file name. Using default 'example.txt'.");
            fileName = "example.txt";
        }

        if (!fileName.EndsWith(".txt"))
        {
            fileName += ".txt";  // Ensure it has a .txt extension
        }

        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
        _repository.SaveEntries(filePath);
        Console.WriteLine($"Entries saved to {filePath}");
    }
}