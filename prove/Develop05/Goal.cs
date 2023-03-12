public abstract class Goal
{
    private int _userLevel;
    private int _addScore;
public List<Goal> goals = new List<Goal>();
public List<Goal> completeGoals = new List<Goal>();
private string _title;
private string _discription;

public Goal(string title, string discription, string completeCheck)
{
    _title = title;
    _discription = discription;
    
}
public string getTitle()
{
    return _title;
}
public string getDiscription()
{
    return _discription;
}



public int userCompleteGoals()
{
    
    
    Console.WriteLine("Which Goal would you like to complete?");
    int i = 1;
    foreach (Goal g in goals)
    {
    Console.WriteLine($"{i}. {g}"); 
    i++;
    }
    int userCompleteGoalSelection = int.Parse(Console.ReadLine());
    userCompleteGoalSelection = userCompleteGoalSelection - 1;
    var finishedGoal = goals[userCompleteGoalSelection];
    completeGoals.Add(finishedGoal);
    goals.RemoveAt(userCompleteGoalSelection);
    _addScore = _addScore + 100;
     if (_addScore >= 1000)
    {
        
        _addScore = _addScore - 1000;
    }
    return _userLevel = _userLevel + 1;
}

public int BonusPoints()
{
    return 0;
}


    //isComplete(): bool w/Overide
    //RecordGoal(): bool w/Overide
    //_name
    //_discription
    //_completionPoints
    //getDisplayScreen(): string
}