public class CampingAssignment : Assignment
{
    private string _classname;
    private string _campsite;
    private string _equipment;

    public CampingAssignment(string classname ,string studentName, string topic, string campsite, string equipment) : base(classname,studentName, topic)
    {
        _classname = classname;
        _campsite = campsite;
        _equipment = equipment;
    }

    public string GetClassName()
    {
        return _classname;
    }

    public string GetCampingInformation()
    {
        return $"Campsite: {_campsite} Equipment: {_equipment}";
    }

    public new string GetSummary()
    {
        return $"{_campsite} {_equipment} by {GetStudentName()}";
    }
}