using System;
public class Assignment
{
    private string _className;
    private string _studentName;
    private string _topic;
    
    public Assignment(string classname, string studentName, string topic)
    {
        _className = classname;
        _studentName = studentName;
        _topic = topic;
    }

    public string GetClassName()
    {
        return _className;
    }
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    public string GetStudentName()
    {
        return _studentName;
    }
}