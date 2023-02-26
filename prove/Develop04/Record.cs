

public class Record : IntroOutro
{
    private int _time;
    public Record(string intro, string discription, int time):base(intro, discription, time)
    {
        _time = time;
    }
    List<string> r = new List<string>();
    public void recordAct()
    {
    DateTime startTime = DateTime.Now;
    DateTime futureTime = startTime.AddSeconds(_time);

    Thread.Sleep(3000);

    string prompt = getPrompt();
    Console.WriteLine(prompt);
    
    while (DateTime.Now < futureTime)
    {
        string userAnswer = Console.ReadLine();
        r.Add(userAnswer);
    }
    int volume = r.Count();
    Console.WriteLine($"Congradulations you wrote {volume} items");

    }

    private string[] prompts =
    {
        "What brings you joy?",
        "Describe a place where you felt happiest.",
        "What was your greatest fear, and how did you conquer it?",
        "Write a letter to someone that you always want to thank but have never had the chance to do so.",
        "What is something that you would like to change about yourself? How can you change it?"
    };
    public string getPrompt()
    {
        Random randomGenerator = new Random();
        int promptNumber = randomGenerator.Next(0,prompts.Length);
        return prompts[promptNumber];
    }

}