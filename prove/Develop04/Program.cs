// Program file is just the interface to show the menu and start the activities. 
// It doesn't need to know about the internals of the activities.
// It should be simple and easy to understand.
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

            string choice = Console.ReadLine().ToLower();


                if (choice == "4" || choice == "quit" || choice == "four") break;

            MindfulnessActivity activity = choice switch
            {
                "1" or "one" => new BreathingActivity(), //leading to breathing activity
                "2" or "two" => new ReflectionActivity(), //leading to reflection activity
                "3" or "three" => new ListingActivity(), //leading to listing activity
                _ => null // invalid input
            };



            if (activity != null)
                {
                    activity.RunActivity();
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again. please press enter to continue");
                    Console.ReadLine();
                }
            }
        }
    }
