

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

        
        while (DateTime.Now < futureTime)
        {
            
            getBreathin();
            getBreathOut();
                      
            
        }
    }        
        private void getBreathin()
        {
            Console.Write("\nBreath in... 5");
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
            Console.Write("\nBreath out ... 5");
            
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