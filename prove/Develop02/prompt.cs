using System;

//class works do not touch
// Repository Class: Handles data storage and retrieval
public class Prompt
{
    public string _prompt;
    public static string GetPrompt()
    {
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

    // Display the prompt
    public static void Display()
    {
        Console.WriteLine(GetPrompt());
    }
}

