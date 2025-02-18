

public class PowerAssignment : Assignment
{
    private string _level;
    private string _skill;

    public PowerAssignment(string studentName, string topic, string level, string skill) : base(studentName, topic)
    {
        _level = level;
        _skill = skill;
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