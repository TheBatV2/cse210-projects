public class Event
{
    //Event Title, Description, Date, Time, and Address

    private string _type;
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _address;

    public Event(string type, string title, string description, string date, string time, string address)
    {
        _type = type;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    } 

    public string GetStandard()
    {
        return $"{_title}, \n{_description} \n{_date}-{_time}\n{_address}\n";
    }

   
     public string GetShort()
    {
        return $"{_type}, {_title}, {_date}\n";
    }
}