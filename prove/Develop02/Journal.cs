using System;
using System.Collections.Generic;

// Journal Class: Manages journal entries and operations
public class Journal
{
    //write the entry
    public void WriteEntry()
    {
     
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
                    Console.WriteLine($"[{_entry._date}] {_entry._content}");
                }
            }
    }
    //load the entries
    public void LoadEntries()
    {
        Repository repository = new Repository();
        repository.LoadEntries();
        Console.WriteLine("Entries loadeing.");
        
    }
    public void SaveEntries()
    {
        Repository repository = new Repository();
        repository.SaveEntries();
        Console.WriteLine("Entries saved.");
    }
}