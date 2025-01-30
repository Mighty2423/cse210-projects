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
    public void WriteEntry()
    {
        Entry entry = new Entry();
        entry._date = DateTime.Now.ToString();
        entry._prompt = Prompt.GetPrompt();
        Console.WriteLine(entry._prompt);
        Console.WriteLine("Enter the content:");
        entry._content = Console.ReadLine();
        Repository repository = new Repository();
        repository.AddEntry(entry);
        Console.WriteLine("Entry saved.");
    }
     //fix with class and possibly here
     //display the entries
    public void DisplayEntries()
    {
        List<Entry> entries = _repository.GetEntries();
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
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
        Repository repository = new Repository();
        Console.WriteLine("Entries loading.");
        Console.WriteLine("Entries loaded.");
        string filePath = "path/to/your/file.txt"; // specify the file path
        repository.LoadEntries(filePath);

        
        
    }
    //works do not touch
    //save the entries
    public void SaveEntries()
    {
        Repository repository = new Repository();
        string filePath = @"C:\Users\alton\source\cse210-projects\prove\Develop02\example.txt"; // specify the file path
        repository.SaveEntries(filePath);
        Console.WriteLine("Entries saved.");
    }
}