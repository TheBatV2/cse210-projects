public class Writing : Student
{
    private string _title;

    public Writing(string studentName, string topic, string title):base (studentName, topic)
    {
        _title = title;
    }

    public string GetBook()
    {
        string studentName = GetStudent(); 
        
        return $"{_title} by {studentName}";
    }
    


}