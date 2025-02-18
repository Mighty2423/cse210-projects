using System;

class Program
{
    static void Main()
    {
        // Test Assignment Class
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine();

        // Test MathAssignment Class
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine();

        // Test WritingAssignment Class
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
        Console.WriteLine();

        // Test poertyAssignment Class
        PoetryAssignment poetryAssignment = new PoetryAssignment("John Doe", "Poetry", "The Raven", "Edgar Allen Poe");
        Console.WriteLine(poetryAssignment.GetSummary());
        Console.WriteLine(poetryAssignment.GetPoetryInformation());
        Console.WriteLine();

        // Test powerAssignment Class
        PowerAssignment powerAssignment = new PowerAssignment("Jane powel", "welder", "Begginger", "MIG");
        Console.WriteLine(powerAssignment.GetSummary());
        Console.WriteLine(powerAssignment.GetPowerInformation());
        Console.WriteLine();

        // Test campingAssignment Class
        CampingAssignment campingAssignment = new CampingAssignment("John Smith", "Camping", "Yellowstone", "Tent, Sleeping Bag, Flashlight");
        CampingAssignment campingAssignment2 = new CampingAssignment("Blan ranger", "Camping survival", "Newyork", "box tent, Blanket, Flashlight");
        Console.WriteLine(campingAssignment.GetSummary());
        Console.WriteLine(campingAssignment.GetCampingInformation());
        Console.WriteLine(campingAssignment2.GetSummary());
        Console.WriteLine(campingAssignment2.GetCampingInformation());
        Console.WriteLine();
    }
}
