using System;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Display the welcome message
        DisplayWelcome();

        // Step 2: Prompt for and retrieve the user's name
        string userName = PromptUserName();

        // Step 3: Prompt for and retrieve the user's favorite number
        int favoriteNumber = PromptUserNumber();

        // Step 4: Square the number
        int squaredNumber = SquareNumber(favoriteNumber);

        // Step 5: Display the result
        DisplayResult(userName, squaredNumber);
    }

    // Function to display the welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    

}