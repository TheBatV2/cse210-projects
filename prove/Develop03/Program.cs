using System;

class Program
{
    static void Main(string[] args)

    
    {
        Scripture original = new Scripture();
        //sets userinput for errors
        string userInput = "";

        //displays a welcome message
        DisplayWelcomeMessage();

        //displays original scripture
        string referance = original.getReferance();
        string originalScripture = original.getScripture();
        
        
        Console.WriteLine($"{referance}: {originalScripture}");

        //sets a while loop to quit if "quit" is typed


        while(userInput != "quit")
        {
        
        userInput = Console.ReadLine();
        Console.Clear();
        DisplayScripture scripture = new DisplayScripture(originalScripture);
        scripture.Display();
        

        }


        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("/nWelcome to the Scripture Memorizer, press Enter when you would like words to dissapear. \nType Quit when done.");
        }
    }
}
// And by the power of the holy ghost ye may know the truth of all things  Moroni 10:5  5 instances