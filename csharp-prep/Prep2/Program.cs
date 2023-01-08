using System;

class Program
{
    static void Main(string[] args)
    {
       Console.Write("What is you Grade Score? ");
       string userInput = Console.ReadLine();
       int number = int.Parse(userInput);

       if (number >= 90)
       {
        Console.WriteLine("You have an A");
       }  
       else if (number >= 80)
       {
        Console.WriteLine("You Have a B");
       }   
        else if (number >= 70)
       {
        Console.WriteLine("You Have a C");
       }   
        else if (number >= 60)
       {
        Console.WriteLine("You Have a D");
       }   
       
        else 
       {
        Console.WriteLine("You Have a F");
       }   
        }
}