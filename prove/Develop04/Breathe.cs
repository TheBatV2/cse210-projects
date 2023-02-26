

public class Breathe : IntroOutro
{
private int _time;
public Breathe(string intro, string discription, int time):base(intro, discription, time)
{


 DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(time);

        Thread.Sleep(3000);

        DateTime currentTime = DateTime.Now;
        if (currentTime < futureTime)
        {

        }
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
}
}