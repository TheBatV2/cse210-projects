
public class Reflect : IntroOutro
{
    private int _time;

    public Reflect(string intro, string discription, int time):base(intro, discription, time)
    {
        _time = time;
    }

    public void reflectAct()
    {  
        Thread.Sleep(3000);
        string primary = getPrimaryPrompt();
        // string secondary = getSecondaryPrompt();
        Console.WriteLine(primary);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_time);


       
        while (DateTime.Now < futureTime)
        {
            Console.Write("-"); 
            Thread.Sleep(1000);
            Console.Write("\b \b"); 
            Console.Write("\\"); 
            Thread.Sleep(1000);
            Console.Write("\b \b"); 
            Console.Write("|"); 
            Thread.Sleep(1000);
            Console.Write("\b \b"); 
            Console.Write("/"); 
            Thread.Sleep(1000);
            Console.Write("\b \b"); 
            string secondary = getSecondaryPrompt();
            Console.WriteLine(secondary);
        }
    }

    private string[] primaryPrompts = 
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    
    string getPrimaryPrompt()
    {
        Random randomGenerator = new Random();
        int promptNumber = randomGenerator.Next(0,primaryPrompts.Length);
        return primaryPrompts[promptNumber];
    
    }

    private string[] secondaryPrompts = 
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    string getSecondaryPrompt()
    {
        Random randomGenerator = new Random();
        int promptNumber = randomGenerator.Next(0,secondaryPrompts.Length);
        return secondaryPrompts[promptNumber];
    
    }
}