using System;

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student("Spencer Barbre", "Addition");
        Console.WriteLine(s1.GetStudent());


        Math s2 = new Math("Stepheine Barbre", "Subtraction", "12.3", "3-5");
        Console.WriteLine(s2.GetStudent());

        Writing s3 = new Writing("Thomas S Kidd", "American History", "American History, 1492 - Present");  
        Console.WriteLine(s3.GetStudent());  
        Console.WriteLine(s3.GetBook());
    }
}