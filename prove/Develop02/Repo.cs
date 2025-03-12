
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



    // Load the entries from a file
    public void LoadEntries(string filePath)
    {
        // Check if the file exists
        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                _entries.Clear();
                if (reader.Peek() == -1)
                {
                    // File is empty
                    Console.WriteLine("File is empty. No entries loaded.");
                    return;
                }
                // Read the file line by line
                while (!reader.EndOfStream)
                {
                    Entry entry = new Entry();
                    entry._date = reader.ReadLine();
                    entry._prompt = reader.ReadLine();
                    entry._content = reader.ReadLine();

                    if (entry._date != null && entry._prompt != null && entry._content != null)
                    {
                        _entries.Add(entry);
                    }
                }
            }
            // show how many entries are loaded
            Console.WriteLine($"Loaded {_entries.Count} entries from {filePath}");
        }
        //if file not found
        else
        {
            Console.WriteLine("File not found.");
        }
    }


    // Save the entries to a file
    public void SaveEntries(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath,true))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry._date);
                writer.WriteLine(entry._prompt);
                writer.WriteLine(entry._content);
            }
        }
        // show enties are saved where
        Console.WriteLine("Entries saved to " + filePath);
        //Clear the list of entries
        _entries.Clear();
    }
}