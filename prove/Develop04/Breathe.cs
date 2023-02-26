

public class Breathe : IntroOutro
{
    private int _time;
    public Breathe(string intro, string discription, int time):base(intro, discription, time)
    {
        _time = time;
    }

    public void breatheAct()
    {
    DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_time);

        Thread.Sleep(3000);

        DateTime currentTime = DateTime.Now;
        if (currentTime < futureTime)
        {
            
            getBreathin();
            getBreathOut();
                       
            
        }
    }        
        private void getBreathin()
        {
            for(int i = 5; i != 0; i--)
          
            Console.Write($"Breath in... {i}");
            Thread.Sleep(1000);
            Console.Write("\b \b"); 



        }

        private void getBreathOut()
        {
            for(int i = 5; i != 0; i--)
            Console.Write($"Breath out... {i}");
            Thread.Sleep(1000);
            Console.Write("\b \b"); 
        }   

            // Console.Write("Breath in... 5");
            // Thread.Sleep(1000);

            // Console.Write("\b \b"); // Erase the + character
            // Thread.Sleep(1000);
            // Console.Write("4"); // Replace it with the - character
            // Thread.Sleep(1000);
            // Console.Write("\b \b"); // Erase the + character
            // Thread.Sleep(1000);
            // Console.Write("3"); // Replace it with the - character
            // Thread.Sleep(1000);
            // Console.Write("\b \b"); // Erase the + character
            // Thread.Sleep(1000);
            // Console.Write("2"); // Replace it with the - character
            // Thread.Sleep(1000);
            // Console.Write("\b \b"); // Erase the + character
            // Console.Write("1"); // Replace it with the - character
            // Thread.Sleep(1000);
            // Console.Write("\b \b"); // Erase the + character
}