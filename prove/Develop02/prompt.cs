using System;

//class works do not touch
// Repository Class: Handles data storage and retrieval
public class Prompt
{
    // Prompt properties
    public string _prompt;
    //get the prompt
    public static string GetPrompt()
    {
        // Array of prompts
        string[] prompts = new string[]
        {
            "How are you feeling today?",
            "What did you learn today?",
            "What are you grateful for today?",
            "What are you looking forward to tomorrow?",
            "What is your favorite memory you want ot save?"
        };
        return prompts[new Random().Next(prompts.Length)];
    }

    // works do not touch
    public static void Display()
    {
        Console.WriteLine(GetPrompt());
    }
}

