public abstract class Activity
{
    private string _date;
    protected double _activityTime;
    private string _activityType;
    public Activity(string date, double activityTime, string activityType)
    {
        _date = date;
        _activityTime = activityTime;
        _activityType = activityType;
    }


     public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();
  
    public string GetSummary()
    {
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();

       return $"{_date}, {_activityType} ({_activityTime} min): - Distance {distance} miles, Speed {speed} Mph, Pace {pace} min per mile"; 
    }

}
