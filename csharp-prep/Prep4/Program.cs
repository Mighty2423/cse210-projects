using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }

        } while (number != 0);

        ComputeResults(numbers);
    }

    static void ComputeResults(List<int> numbers)
    {
        // Compute sum, average, and maximum
        int sum = 0;
        int max = int.MinValue;
        int smallestPositive = int.MaxValue;

        foreach (int num in numbers)
        {
            sum += num;

            if (num > max)
            {
                max = num;
            }

            if (num > 0 && num < smallestPositive)
            {
                smallestPositive = num;
            }
        }

        double average = (double)sum / numbers.Count;

        // Sort the list
        numbers.Sort();

        // Display results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        Console.WriteLine("The sorted list is: ");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}