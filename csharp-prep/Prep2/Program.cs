using System;

class Program
{
    static void Main(string[] args)
    {
        // grade prompt
        Console.WriteLine("Enter your numerical grade:  ");
        string input = Console.ReadLine();
        int grade;

        //check if input is a vaild number
        if (int.TryParse(input, out grade))
        {
            if (grade >= 90)
            {
                Console.WriteLine("A");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("B");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("C");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("D");
            }
            else if (grade < 60)
            {
                Console.WriteLine("F");
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}