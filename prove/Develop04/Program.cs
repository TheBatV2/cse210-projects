using System;

class Program
{
    static void Main(string[] args)
    {
        int _userInput = 0;
    
        Console.WriteLine(Menu());
        Console.WriteLine(Welcome());

        Breathe r1 = new Breathe("Welcome to the Breathing exersise", "After a short pause please follow the instructions on screen", _userInput);
        Console.WriteLine("intro");
        Console.WriteLine("breatheAct");
        Console.WriteLine("outro");


        Reflect r2 = new Reflect("Welcome to the Breathing exersise", "After a short pause please follow the instructions on screen", _userInput);
        Console.WriteLine("intro");
        Console.WriteLine("breatheAct");
        Console.WriteLine("outro");


        Record r3 = new Record("Welcome to the Breathing exersise", "After a short pause please follow the instructions on screen", _userInput);
        Console.WriteLine("intro");
        Console.WriteLine("breatheAct");
        Console.WriteLine("outro");


        string Welcome()
        {

        }

        string Menu()
        {
            string _menu = "Welcome to your Relaxation program, \nWhat would you like to do?\n(Please enter the number of your selection)\n\n1. Breathing Excercise.\n2.Reflection Exercise.\n3. Recording Exsercise.";
            return _menu;
        }



    }
}