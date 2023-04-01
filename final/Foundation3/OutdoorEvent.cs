public class OutdoorEvent : Event
{
    //need to track the weather forecast
    private string _forecast;

    public OutdoorEvent(string type, string title, string description, string date, string time, string address, string forecast) : base (type, title, description, date, time, address)
    {
        _forecast = forecast;
    }

    public string GetFullOutdoor()
    {
        string items = GetStandard();
        return $"{_forecast}, {items}\n";
    }
}