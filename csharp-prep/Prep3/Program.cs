using System;

class Program
{
    static void Main(string[] args)
    {
        //ask the user for their number
        Console.WriteLine("What is the magic number ? ");
        int magicNumber = int.Parse(Console.ReadLine());


        //ask the user for their guess
        Console.WriteLine("What is your guess ? ");
        int guess = int.Parse(Console.ReadLine());

        //check if the guess is correct
        if (guess == magicNumber)
        {
            Console.WriteLine("You guessed it right!");
        }
        else
        {
            Console.WriteLine("You guessed it wrong!");
        }

        //check if the guess is too high
        if (guess > magicNumber)
        {
            Console.WriteLine("Your guess is too high!");
        }

        //check if the guess is too low
        if (guess < magicNumber)
        {
            Console.WriteLine("Your guess is too low!");
        }

        //loop

    }
}