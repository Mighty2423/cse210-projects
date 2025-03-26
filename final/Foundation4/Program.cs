using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of activities
        List<Activity> activities = new List<Activity>();

        // Add some activities to the list
        activities.Add(new Running("2023-10-01", 30, 3.0));
        activities.Add(new Cycling("2023-10-02", 45, 15.0));
        activities.Add(new Swimming("2023-10-03", 60, 20));

        // Display summaries of all activities
        foreach (var activity in activities)
        {
                if (activity is Running)
                {
                    Console.WriteLine($"Running Activity: {activity.GetSummaryOfActivity()}");
                }
                else if (activity is Cycling)
                {
                    Console.WriteLine($"Cycling Activity: {activity.GetSummaryOfActivity()}");
                }
                else if (activity is Swimming)
                {
                    Console.WriteLine($"Swimming Activity: {activity.GetSummaryOfActivity()}");
                }
                else
                {
                    Console.WriteLine($"Unknown Activity: {activity.GetSummaryOfActivity()}");
                }
        }
    }
}