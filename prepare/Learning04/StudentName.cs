
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
}