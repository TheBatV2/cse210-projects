using System;

class Program
{
    static void Main(string[] args)
    {
        int userInput = 0;
        string userChoice = "";
        Menu();
        userChoice = Menu();
        Length();
        userInput = Length();
        
        if (userChoice == "1")
        {
        
        Breathe r1 = new Breathe("Welcome to the Breathing exersise", "After a short pause please follow the instructions on screen", userInput);
        Console.WriteLine(r1.getIntro());
        Console.WriteLine(r1.breatheAct());
        Console.WriteLine(r1.outro());
        }


        else if (userChoice == "2")
        {
        Reflect r2 = new Reflect("Welcome to the Breathing exersise", "After a short pause please follow the instructions on screen", userInput);
        Console.WriteLine(r2.getIntro());
        Console.WriteLine(r2.reflectAct());
        Console.WriteLine(r2.outro());
        }

        else if (userChoice =="3")
        {
        Record r3 = new Record("Welcome to the Breathing exersise", "After a short pause please follow the instructions on screen", userInput);
        Console.WriteLine(r3.getIntro());
        Console.WriteLine(r3.recordAct());
        Console.WriteLine(r3.outro());
        }

        else
        {
            Environment.Exit(0);     
        }

      

        string Menu()
        {
            Console.WriteLine("Welcome to your Relaxation program, \nWhat would you like to do?\n(Please enter the number of your selection)\n\n1. Breathing Excercise.\n2.Reflection Exercise.\n3. Recording Exsercise.\n4. Quit.");
            string _menu = Console.ReadLine();
            return _menu;
        }

        int Length()
        {
            Console.WriteLine("How long would you like to do this excercise? (seconds)");
            string userStrInput = Console.ReadLine();
            int userTime = Convert.ToInt32(userStrInput);
            userTime = userTime * 1000;
            return userTime;
        }



    }
}