using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for the magic number
        Console.WriteLine("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());

        int guess = -1; // Initialize the guess to a value that is not equal to the magic number

        // Loop until the guess matches the magic number
        while (guess != magicNumber)
        {
            // Ask the user for their guess
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            // Check if the guess is correct
            if (guess == magicNumber)
            {
                Console.WriteLine("You guessed it right!");
            }
            else
            {
                // Provide feedback if the guess is too high or too low
                if (guess > magicNumber)
                {
                    Console.WriteLine("Your guess is too high!");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Your guess is too low!");
                }
            }
        }
    }
}
