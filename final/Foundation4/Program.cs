using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of activities
        List<Activity> activities = new List<Activity>();

        // Add some activities to the list
        // Running activity data
        activities.Add(new Running("2023-10-01", 30, 3.0));
        // Cycling activity data
        activities.Add(new Cycling("2023-10-02", 45, 15.0));
        // Swimming activity data
        activities.Add(new Swimming("2023-10-03", 60, 20));

        // Display summaries of all activities
        foreach (var activity in activities)
        {
                if (activity is Running)
                {
                    // Display a summary of the running activity
                    Console.WriteLine($"Running Activity: {activity.GetSummaryOfActivity()}");
                }
                else if (activity is Cycling)
                {
                    // Display a summary of the cycling activity
                    Console.WriteLine($"Cycling Activity: {activity.GetSummaryOfActivity()}");
                }
                else if (activity is Swimming)
                {
                    // Display a summary of the swimming activity
                    Console.WriteLine($"Swimming Activity: {activity.GetSummaryOfActivity()}");
                }
                else
                {
                    // Display a message for unknown activities
                    Console.WriteLine($"Unknown Activity: {activity.GetSummaryOfActivity()}");
                }
        }
    }
}