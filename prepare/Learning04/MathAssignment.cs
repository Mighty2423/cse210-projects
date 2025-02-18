using System;
public class MathAssignment : Assignment
{
    private string _className;
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string classname,string studentName, string topic, string textbookSection, string problems) : base(classname, studentName, topic)
    {
        _className = classname;
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetClassName()
    {
        return _className;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems: {_problems}";
    }
}
