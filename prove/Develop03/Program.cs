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
        Console.WriteLine("Let's get started!");
        Console.ReadLine();
        
        Game game = new Game();
        game.Start();
        game.End();
    }
}