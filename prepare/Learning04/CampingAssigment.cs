public class CampingAssignment : Assignment
{
    private string _campsite;
    private string _equipment;

    public CampingAssignment(string studentName, string topic, string campsite, string equipment) : base(studentName, topic)
    {
        _campsite = campsite;
        _equipment = equipment;
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