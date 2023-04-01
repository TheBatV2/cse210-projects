public class ReceptionEvent : Event
{
    // RSVP, or register, beforehand
    private string _rsvpEmail;

    public ReceptionEvent(string type, string title, string description, string date, string time, string address, string rsvpEmail) : base (type, title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public string GetFullReception()
    {
    string items = GetStandard();
    return $"{_rsvpEmail}, \n{items}\n";
    }
}   