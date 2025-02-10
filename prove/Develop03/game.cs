using System;

public class Game
{
    public void Start()
    {
    Content reference = new Content("Proverbs", 3, 5, 6);
        string scriptureText = "Trust in the Lord with all your heart and lean not on your own understanding;";
        Scripture scripture = new Scripture(reference, scriptureText);
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture);
            Console.WriteLine("\nPress Enter to hide words or until you type 'quit' to exit.");
            string input = Console.ReadLine();

            if (!scripture.HideRandomWords(3))
            {
                Console.Clear();
                Console.WriteLine("All words are hidden!\n");
            }

            if (Console.ReadLine().ToLower() == "quit")
            {
                End();
                break;
            } 
                }
    }      

    public void End()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Game Over!");
        }
    }
}