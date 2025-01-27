using System;
using System.Collections.Generic;

// Journal Class: Manages journal entries and operations
public class Journal
{
    //write the entry
    public void WriteEntry()
    {   
        Console.WriteLine("Enter the date of the entry: ");
        string date = Console.ReadLine();
        Console.WriteLine("Enter the content of the entry: ");
        string content = Console.ReadLine();
        Console.WriteLine("Enter the prompt of the entry: ");
        string prompt = Console.ReadLine();
        Entry entry = new Entry;
        }
     //display the entries
    public void DisplayEntries()
    {

    }
    //load the entries
    public void LoadEntries()
    {
    //save the entries
    }
    public void SaveEntries()
    {
        
    }
}