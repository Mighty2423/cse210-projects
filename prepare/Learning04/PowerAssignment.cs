

public class PowerAssignment : Assignment
{
    private string _classname;
    private string _level;
    private string _skill;

    public PowerAssignment(string classname,string studentName, string topic, string level, string skill) : base( classname,studentName, topic)
    {
        _classname = classname;
        _level = level;
        _skill = skill;
    }

    public string GetClassName()
    {
        return _classname;
    }

    public string GetPowerInformation()
    {
        return $"Level: {_level} Skill: {_skill}";
    }

    public new string GetSummary()
    {
        return $"{_level} {_skill} by {GetStudentName()}";
    }
}