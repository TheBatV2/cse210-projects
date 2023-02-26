public class IntroOutro
{

    private string _intro;

    private string _discription;

    private int _usernumber;
    public IntroOutro(string intro, string discription, int usernumber)
    {
        _intro = intro;
        _discription = discription;
        
        _usernumber = usernumber;
    }

    public string getIntro()
    {
        return $"{_intro} \n{_discription}";
    }

    public string getOutro()
    {
        string _outro = "\nThank you for participating in this activity. \nEnjoy the rest of your day.";
        return _outro;
    }

    
}

//  DateTime startTime = DateTime.Now;
//         DateTime futureTime = startTime.AddSeconds(10000 - 5000);

//         Thread.Sleep(3000);

//         DateTime currentTime = DateTime.Now;
//         if (currentTime < futureTime)
//         {
            
//             for(int i = dividedNumber/2; i != 0; i--);
//             Console.WriteLine(GetBreathIn);
//             Console.WriteLine(GetBreathOut);
            
            
//             //Console.Write("+");
//             // Console.Write("Breath in... 5");
//             // Thread.Sleep(1000);

//             // Console.Write("\b \b"); // Erase the + character
//             // Thread.Sleep(1000);
//             // Console.Write("4"); // Replace it with the - character
//             // Thread.Sleep(1000);
//             // Console.Write("\b \b"); // Erase the + character
//             // Thread.Sleep(1000);
//             // Console.Write("3"); // Replace it with the - character
//             // Thread.Sleep(1000);
//             // Console.Write("\b \b"); // Erase the + character
//             // Thread.Sleep(1000);
//             // Console.Write("2"); // Replace it with the - character
//             // Thread.Sleep(1000);
//             // Console.Write("\b \b"); // Erase the + character
//             // Console.Write("1"); // Replace it with the - character
//             // Thread.Sleep(1000);
//             // Console.Write("\b \b"); // Erase the + character
            
//         }