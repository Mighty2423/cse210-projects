using System;

public class WritingAssignment : Assignment
{
    private string _classname;
    private string _title;
    public WritingAssignment(string classname,string studentName, string topic, string title) : base(classname,studentName, topic)
    {
        _classname = classname;
        _title = title;
    }
    public string GetClassName()
    {
        return _classname;
    }
    public new string GetSummary()
    {
        return $"{_title} by {GetStudentName()}";
    }
    public string GetWritingInformation()
    {
        return $"Title: {_title}";
    }
}
