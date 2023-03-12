//simple goals are one time goals, with a one time point acquisition; somewhere around 100 points. 
public class SimpleGoal : Goal
{
    private string _completeCheck;
    public SimpleGoal(string title, string discription, string completeCheck) : base (title, discription)
    {
        _completeCheck = completeCheck;
    }

  
}


//RecordGoal():int
//isComplete(): bool