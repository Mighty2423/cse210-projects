using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask for the user's first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // Ask for the user's last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Ask for the user's age
        Console.Write("Whats your age? ");
        int age = Convert.ToInt32(Console.ReadLine());

        // Display the name in the specified format
        Console.WriteLine($"Your name is  {firstName} {lastName} ,age {age}.");
    }
}