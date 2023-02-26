using System;

class Program
{
    static void Main(string[] args)
    {
               
        int userInput = 0;
        string userChoice = "";
        Menu();
        
               
        
        if (userChoice == "1")
        {
        
        Breathe r1 = new Breathe("Welcome to the Breathing exersise", "After a short pause please follow the instructions on screen", userInput);
        Console.WriteLine(r1.getIntro());
       
        r1.breatheAct();
        Console.WriteLine(r1.getOutro());
        }


        else if (userChoice == "2")
        {
        Reflect r2 = new Reflect("Welcome to the Reflection exersise", "After a short pause please follow the instructions on screen", userInput);
        Console.WriteLine(r2.getIntro());
        
        r2.reflectAct();
        Console.WriteLine(r2.getOutro());
        }

        else if (userChoice =="3")
        {
        Record r3 = new Record("Welcome to the Recording exersise", "After a short pause please follow the instructions on screen", userInput);
        Console.WriteLine(r3.getIntro());
        
        r3.recordAct();
        Console.WriteLine(r3.getOutro());
        }

        else
        {
            Environment.Exit(0);     
        }

      

        void Menu()
        {
            Console.WriteLine("Welcome to your Relaxation program, \nWhat would you like to do?\n(Please enter the number of your selection)\n\n1. Breathing Excercise.\n2. Reflection Exercise.\n3. Recording Exsercise.\n4. Quit.");
            string menu = Console.ReadLine();
            userChoice = menu;
            
        }

       



    }
}