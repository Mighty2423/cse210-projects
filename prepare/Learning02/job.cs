using System;

public class Job
{
    //attributes varibles member

    public string _jobTitle;
    public string _company;
    public int _startYear;

    public int _endyear ;
    
    // display method job details
    public void display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endyear}");
    }
}