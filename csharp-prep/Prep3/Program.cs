using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,100);
        int userNumber = -1;
        
        

        while(userNumber != number)
        {
            Console.WriteLine("Please guess a number between 1 and 100 to see if you can guess the magic number.");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber == number)
                {
                    Console.WriteLine("Congrats you guessed the number!  Play again?  Y/N ");
                    string userRestart = Console.ReadLine();
                    
                }

            else if (userNumber > number)
                {
                    Console.Write("Lower, ");
                }    

            else
                {
                    Console.Write("Higher, ");
                }    
        } 



        
            
        
    }
}