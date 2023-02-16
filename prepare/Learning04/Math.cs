public class Math : Student
{
    private string _section;
    private string _problems;

    public Math(string studentName, string topic, string section, string problems):base (studentName, topic)
    {
        _section = section;
        _problems = problems;
    }
}