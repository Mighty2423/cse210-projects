using System;
using System.IO;

// Repository Class: Handles data storage and retrieval 

public class Repository
{
    private List<Entry> entries = new List<Entry>();

        public void AddEntry(Entry entry)
        {
            entries.Add(entry);
        }

        public List<Entry> GetEntries()
        {
            return entries;
        }

        public void LoadEntries()
        {
    
        }

        public void SaveEntries()
        {
            {
        string filePath = @"C:\Users\alton\source\cse210-projects\prove\Develop02\example.txt";
        string content = "This is a line of text.";

        // Create or append to the file
        using (StreamWriter writer = new StreamWriter(filePath, append: true))
        {
            writer.WriteLine(content);
        }

        // Optionally, inform the user
        Console.WriteLine($"Content appended to {filePath}");
    }

        }
}