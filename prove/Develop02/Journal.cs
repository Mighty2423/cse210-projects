using System;
using System.Collections.Generic;

// Journal Class: Manages journal entries and operations
public class Journal
{
    //write the entry
    public void WriteEntry()
    {
        Entry entry = new Entry();
        Console.WriteLine("Enter the date:");
        entry._date = Console.ReadLine();
        Console.WriteLine("Enter the content:");
        entry._prompt = Console.ReadLine();
        entry.display();
        Repository repository = new Repository();
        repository.AddEntry(entry);
    }
     //display the entries
    public void DisplayEntries()
    {
        Repository repository = new Repository();
        List<Entry> entries = repository.GetEntries();
            if (entries.Count == 0)
            {
                Console.WriteLine("No entries found.");
            }
            else
            {
                foreach (Entry _entry in entries)
                {
                    Console.WriteLine($"[{_entry._date}] {_entry._content} {_entry._prompt}");
                }
            }
    }
    //load the entries
    public void LoadEntries()
    {
        Repository repository = new Repository();
        Console.WriteLine("Entries loading.");
        Console.WriteLine("Entries loaded.");
        repository.LoadEntries();
        
        
    }
    //save the entries
    public void SaveEntries()
    {
        Repository repository = new Repository();
        repository.SaveEntries();
        Console.WriteLine("Entries saved.");
    }
}