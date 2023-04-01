public class RunningActivity : Activity
{
    private double _distance;
    
    public RunningActivity(string date, double activityTime, string activityType, double distance) : base (date, activityTime, activityType)
    {
        _distance = distance;
    }


    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / _activityTime) * 60;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed(); 
    }
}