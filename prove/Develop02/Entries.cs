using System;
using System.Collections.Generic;

// Entry Class: Represents an individual journal entry
public class Entry{

    public string _date;

    public string _content;
    
    public string _prompt = Prompt.GetPrompt(); 

public void display()
{
    Console.WriteLine($"{_date}\n{_content}\n{_prompt}");
}

}
