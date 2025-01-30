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
        Console.WriteLine("Entries loading.");
        Console.WriteLine("Entries loaded.");
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "example.txt");
        _repository.LoadEntries(filePath);

        
        
    }
    //works do not touch
    //save the entries
    public void SaveEntries(Entry entry)
    {
        _repository.AddEntry(entry);
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "example.txt");
        _repository.SaveEntries(filePath);
        Console.WriteLine("Entries saved.");
}
}