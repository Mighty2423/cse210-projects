using System;
// Game class
public class Game
{
    // Start method
    public void Start()
    {
    // Content reference scriptureText
    Content reference = new Content("Proverbs", 3, 5, 6);
        string scriptureText = "Trust in the Lord with all your heart and lean not on your own understanding;";
        Scripture scripture = new Scripture(reference, scriptureText);
        // While loop
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture);
            Console.WriteLine("\nPress Enter to hide words once that is done to end program type 'quit' or when all words are cleared press enter again to exit.");
            string input = Console.ReadLine();
            
            // If statement to end program 
            if (input == "quit") // End program
            {
                End();
                break;
            }
            else if (input == "") // If Enter is pressed, continue hiding words
            {
                if (!scripture.HideRandomWords(3)) // Hide 3 words per turn
                {
                    Console.Clear();
                    End();
                    Console.WriteLine("All words are hidden!");
                    break;
                }

            }
        }
    }      
    // End method last message to user
    public void End()
    {
        Console.Clear();
        Console.WriteLine("Game Over!");
    
    }
}