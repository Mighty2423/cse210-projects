using System;
using System.Collections.Generic;

public class Resume
{
    //attributes varibles member
    public string _name;
    
    //attributes
    public List<Job> _jobs = new List<Job>();

    // display method resume details
    public void display()
    {
        Console.WriteLine($"Resume of {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.display();
        }
    }
}