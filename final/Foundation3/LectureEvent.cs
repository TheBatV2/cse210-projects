public class LectureEvent : Event
{
    //speaker and have a limited capacity
    private string _speaker;
    private string _capacity;
    
    public LectureEvent(string type, string title, string description, string date, string time, string address, string speaker, string capacity) : base (type, title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetFullLecture()
    {
        string items = GetStandard();
        return $"{_speaker}, {_capacity}\n{items}\n";
    }

}