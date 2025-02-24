class Program
{
    // Main method
    static void Main(string[] args)
    {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Mindfulness Program");
                Console.WriteLine("Select an activity:");
                Console.WriteLine("Please use nubmers to select an activity");
                Console.WriteLine("EXAMPLE: 1 then press enter or the word  of the number'quit' to exit");
                Console.WriteLine("Menu options:");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                if (choice == "4" || choice == "quit" || choice == "four") break;

                MindfulnessActivity activity = null;

                if (choice == "1" || choice == "one") activity = new BreathingActivity();
                else if (choice == "2" || choice == "two") activity = new ReflectionActivity();
                else if (choice == "3"  || choice == "three") activity = new ListingActivity();

                if (activity != null)
                {
                    activity.RunActivity();
                }
                else
                {
                    Console.WriteLine("Invalid choice. Try again.");
                }
            }
        }
    }
