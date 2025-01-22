using System;

class Program
{
    static void Main(string[] args)
    {
        // Create job instances
        Job job1 = new Job
        {
            _jobTitle = "Software Engineer",
            _company = "Microsoft",
            _startYear = 2019,
            _endyear = 2022
        };

        Job job2 = new Job
        {
            _jobTitle = "Product Manager",
            _company = "Apple",
            _startYear = 2022,
            _endyear = 2024
        };

        Job job3 = new Job
        {
            _jobTitle = "data engineer",
            _company = "Google",
            _startYear = 2024,
            _endyear = 2026
        };
        // Create resume instance
        Resume myResume = new Resume
        {
            _name = "John Doe"
        };

        // Add jobs to the resume
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);

        // Display the resume
        myResume.display();
    }
}
