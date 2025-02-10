using System;

//program class
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Bible Word Game!");
        Console.WriteLine("Press enter to start the game. Explanation will follow.");
        Console.ReadLine();
        Console.WriteLine("The game is simple. You will be given a scripture reference"); 
        Console.WriteLine("and a list of words that will disappar every time you press enter.");
        Console.WriteLine("You will have to guess the missing words.");
        Console.ReadLine();
        Console.WriteLine("Let's get started!");
        Console.ReadLine();
        Content reference = new Content("Proverbs", 3, 5, 6);
        string scriptureText = "Trust in the Lord with all your heart and lean not on your own understanding;";
        Scripture scripture = new Scripture(reference, scriptureText);
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture);
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit") break;

            if (!scripture.HideRandomWords(3))
            {
                Console.Clear();
                Console.WriteLine("All words are hidden!\n");
                break;
            }
        }
    }
}