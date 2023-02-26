

public class Breathe : IntroOutro
{
    private int _time;
    public Breathe(string intro, string discription, int time):base(intro, discription, time)
    {
        _time = time * 1000;
    }

    public void breatheAct()
    {
    DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(10000);

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
            Console.Write("Breath in... 5");
            Thread.Sleep(1000);

            Console.Write("\b \b"); // Erase the + character
            
            Console.Write("4"); // Replace it with the - character
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the + character
            
            Console.Write("3"); // Replace it with the - character
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the + character
            
            Console.Write("2"); // Replace it with the - character
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("1"); // Replace it with the - character
            Thread.Sleep(1000);
            // Console.Write("\b \b"); // Erase the + character
        }




        

        private void getBreathOut()
        {
            Console.Write("Breath out ...");
            for(int i = 5; i != 0; i--)
            Console.Write($"{i}");
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