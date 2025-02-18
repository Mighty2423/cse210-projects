using System;

public class WritingAssignment : Assignment
{
    private string _title;
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
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
