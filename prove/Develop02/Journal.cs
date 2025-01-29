using System;
using System.Collections.Generic;
using System.Security.Cryptography;

// Journal Class: Manages journal entries and operations
public class Journal
{
    //works do not touch
    //write the entry
    public void WriteEntry()
    {
        Entry entry = new Entry();
        Console.WriteLine("Press Enter to input today the date:");
        entry._date = Console.ReadLine();
        Console.WriteLine(entry._prompt + "-Enter the content:");
        entry._prompt = Console.ReadLine();
        entry.display();
        Repository repository = new Repository();
        repository.AddEntry(entry);
        repository.AddEntry(entry);
        repository.AddEntry(entry);
    }
     //fix with class and possibly here
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
                    Console.WriteLine($"[{_entry._date}]\n{_entry._content}\n{_entry._prompt}");
                }
            }
    }
    //works do not touch
    //load the entries
    public void LoadEntries()
    {
        Repository repository = new Repository();
        Console.WriteLine("Entries loading.");
        Console.WriteLine("Entries loaded.");
        repository.LoadEntries();
        
        
    }
    //works do not touch
    //save the entries
    public void SaveEntries()
    {
        Repository repository = new Repository();
        repository.SaveEntries();
        Console.WriteLine("Entries saved.");
    }
}