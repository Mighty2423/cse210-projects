class PoetryAssignment : Assignment
{
    private string _classname;
    private string _poemTitle;
    private string _poet;

    public PoetryAssignment(string classname, string studentName, string topic, string poemTitle, string poet)
        : base(classname,studentName, topic)
    {
        _classname = classname;
        _poemTitle = poemTitle;
        _poet = poet;
    }

    public string GetClassName()
    {
        return _classname;
    }

    public string GetPoetryInformation()
    {
        return $"Poem Title: {_poemTitle}, Poet: {_poet}";
    }
}