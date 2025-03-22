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

        foreach (Event e in events)
        {
            Console.WriteLine(e.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(e.GetShortDescription());
            Console.WriteLine();
            Console.WriteLine(e.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}