using System;

class Program
{
    static void Main(string[] args)
    {
       
       // welcomeMessage()
       // readline
       //if user input != quit 
       // menu/
        //
       
       
       Student s1 = new Student("Spencer Barbre", "Addition");
        Console.WriteLine(s1.GetStudentFull());


        Math s2 = new Math("Stepheine Barbre", "Subtraction", "12.3", "3-5");
        Console.WriteLine(s2.GetStudentFull());
        Console.WriteLine(s2.GetMath());

        Writing s3 = new Writing("Thomas S Kidd", "American History", "American History, 1492 - Present.");  
        Console.WriteLine(s3.GetStudentFull());  
        Console.WriteLine(s3.GetBook());
    }
}