

public class Student
{
    private string _studentName;

    private string _topic;

    public Student(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    
    public string GetStudentFull()
    {
        return $"{_studentName} - {_topic}";
    }

    public string GetStudent()
    {
        return $"{_studentName}";
    }


    //_countDown / 5 


}