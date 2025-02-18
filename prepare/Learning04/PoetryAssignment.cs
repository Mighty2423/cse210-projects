using System;

class PoetryAssignment : Assignment
{
    private string _poemTitle;
    private string _poet;

    public PoetryAssignment(string studentName, string topic, string poemTitle, string poet)
        : base(studentName, topic)
    {
        _poemTitle = poemTitle;
        _poet = poet;
    }

    public string GetPoetryInformation()
    {
        return $"Poem Title: {_poemTitle}, Poet: {_poet}";
    }
}