using System;

class Program
{
    static void Main(string[] args)
    {
        
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);

    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program!");
       

    }

    static string PromptUserName()
    {
     Console.WriteLine("What is you name? ");
        string userName = Console.ReadLine();

        return userName;

    }  

    static int PromptUserNumber()
    {  
        Console.WriteLine("Please enter your favorite number: ");
        int userNumber = int.Parse(Console.ReadLine());

        return userNumber;
    }

    static int SquareNumber(int userNumber)
    {
        int squaredNumber = userNumber * userNumber;
        
        return squaredNumber;
    }

    static void DisplayResult(string userName, int squaredNumber)
    {
        Console.WriteLine($"{userName}, The number you gave squared is: {squaredNumber}");
    }
}