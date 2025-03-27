class Program
{
    static void Main(string[] args)
    {

        Event[] events = new Event[]
        {
            new Lecture("C# Programming", "2021-10-01", "10:00", "123 Main St", "John Doe", 100),
            new OutdoorEvent("Picnic", "2021-10-02", "12:00", "456 Elm St", "Sunny"),
            new Reception("Wedding", "2021-10-03", "14:00", "789 Oak St", "Remmey"),
        };

        // list of events to display the short description
        foreach (Event e in events)
        {
            // Display the event details using the methods of the Event class
            Console.WriteLine(e.GetShortDescription());
        }

        //divider
        Console.WriteLine();

        // list of events to display the full details
        foreach (Event e in events)
        {
            Console.WriteLine();
            // Simply display the event type
            Console.WriteLine($"Event Type: {e.GetType().Name} ");
            // Display the event details using the methods of the Event class
            Console.WriteLine(e.GetFullDetails());
            Console.WriteLine();
            // Display the event details using the methods of the Event class
            Console.WriteLine(e.GetShortDescription());
            Console.WriteLine();
            // Display the event details using the methods of the Event class
            Console.WriteLine(e.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}