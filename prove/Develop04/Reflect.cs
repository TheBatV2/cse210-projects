
public class Reflect : IntroOutro
{


    public Reflect(string intro, string discription, int time):base(intro, discription, time)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(time);

        Thread.Sleep(3000);

        DateTime currentTime = DateTime.Now;
        if (currentTime < futureTime)
    }
}