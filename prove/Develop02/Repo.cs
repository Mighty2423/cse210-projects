using System;
using System.IO;
using System.Runtime.CompilerServices;

// Repository Class: Handles data storage and retrieval 
public class Repository
{
    // List of entries
    private List<Entry> entries = new List<Entry>();
        public void AddEntry(Entry entry)
        {
            entries.Add(entry);
        }

        public List<Entry> GetEntries()
        {
            return entries;
        }
    
        // Load the entries from a file
        public void LoadEntries()
        {
            string filePath = @"C:\Users\alton\source\cse210-projects\prove\Develop02\example.txt";

            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }

        // Save the entries to a file
        public void SaveEntries()
        {
            {
    string filePath = @"C:\Users\alton\source\cse210-projects\prove\Develop02\example.txt";
    // Create or append to the file
    using (StreamWriter writer = new StreamWriter(filePath, append: true))
    {
        foreach (Entry _entry in entries)
        {
            writer.WriteLine(_entry._prompt);
        }
        writer.WriteLine(DateTime.Now.ToString());
    }
    
    //inform the user that the content was saved to
    Console.WriteLine($"Content appended to {filePath}");
        }
}
}