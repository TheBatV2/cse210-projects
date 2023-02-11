using System;

class Program
{
    static void Main(string[] args)

    
    {
        Scripture original = new Scripture();
        //sets userinput for errors
        string userInput = "";
        //displays original scripture
        string referance = original.getReferance();
        string originalScripture = original.getScripture();
        Console.WriteLine($"{referance}: {originalScripture}");
        while(userInput != "quit")
        {
        userInput = Console.ReadLine();
        DisplayScripture scripture = new DisplayScripture();
        Console.WriteLine(original.getScripture());
        

        }
    }
}
// And by the power of the holy ghost ye may know the truth of all things  Moroni 10:5  5 instances