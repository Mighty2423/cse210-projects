
public class StudentName
{
    private List<string> _studentNames;
    private List<string> _classname;

    public StudentName(List<string> studentNames, List<string> classname)
    {
        _studentNames = studentNames;
        _classname = classname;
    }

    public string GetAllStudentNames()
    {
        return string.Join(", ", _studentNames);
    }
    public string GetClassName()
    {
        return string.Join(", ", _classname);
    }

    // public string combines getallstudentnames and getclassname side by side
    public string GetsidebySide()
    {
        List<string> combined = new List<string>();
        for (int i = 0; i < _studentNames.Count; i++)
        {
            combined.Add($"{_studentNames[i]} - {_classname[i]}");
        }
            return string.Join(", ", combined);
        }

}