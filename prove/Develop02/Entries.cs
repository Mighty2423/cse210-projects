using System;
using System.Collections.Generic;

//works do not touch
// Entry Class: Represents an individual journal entry
public class Entry{

    public string _date;

    public string _prompt = Prompt.GetPrompt();
    
    public string _content; 

public void Display()

    {

        Console.WriteLine($"Date: {_date}");

        Console.WriteLine($"Prompt: {_prompt}");

        Console.WriteLine($"Content: {_content}");
    }
}