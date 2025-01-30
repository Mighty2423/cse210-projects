using System;
using System.IO;
using System.Runtime.CompilerServices;

// Repository Class: Handles data storage and retrieval 
public class Repository
{
    //not but will figure out
    // List of entries
    private List<Entry> _entries = new List<Entry>();
    
        // Add a new entry to the list
        public void AddEntry(Entry entry)
        {
            _entries.Add(entry);
        }

        // Get all entries
        public List<Entry> GetEntries()
        {
            return _entries;
        }

        
        //need to fix still
        // Load the entries from a file
        public void LoadEntries(string filePath)
        {
            if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                _entries.Clear(); // Clear existing entries before loading new ones
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Entry entry = new Entry();
                    entry._date = reader.ReadLine();
                    entry._prompt = reader.ReadLine();
                    entry._content = reader.ReadLine();
                    _entries.Add(entry);
                }
            }
            Console.WriteLine("Entries loaded from " + filePath);
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    // Save the entries to a file
    public void SaveEntries(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry._date);
                writer.WriteLine(entry._prompt);
                writer.WriteLine(entry._content);
            }
        }
        Console.WriteLine("Entries saved to " + filePath);
    }
}