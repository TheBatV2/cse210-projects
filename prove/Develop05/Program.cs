using System;

class Program
{
    static void Main(string[] args)
    {
        int userDecision = -1;
        string completeCheck = "false";
        List<Goal> goals = new List<Goal>();
        List<Goal> completeGoals = new List<Goal>();
        Welcome();
        while(userDecision != 6)
        {
                userDecision = UserChoice();
                if (userDecision == 1)
                {
                    Console.WriteLine("What type of goal would you like to set?");
                    Console.WriteLine("1. Simple Goal\n 2.Eternal Goal\n Checklist Goal\n 4. Explination");
                    int userGoalSelection = int.Parse(Console.ReadLine());
                    if (userGoalSelection == 1)
                    {
                        Console.WriteLine("What is the Title of your Goal");
                        string title = Console.ReadLine();
                        Console.WriteLine("Please write a description of your Goal");
                        string discription = Console.ReadLine();
                        SimpleGoal sg = new SimpleGoal(title, discription, completeCheck);
                        goals.Add(sg);
                    }
                    
                    
                    else if (userGoalSelection == 2)
                    {
                        Console.WriteLine("What is the Title of your Goal");
                        string title = Console.ReadLine();
                        Console.WriteLine("Please write a description of your Goal");
                        string discription = Console.ReadLine();
                        EternalGoal eg = new EternalGoal(title, discription, completeCheck);
                        goals.Add(eg);
                    }
                    
                    
                    else if (userGoalSelection == 3)
                    {
                        Console.WriteLine("What is the Title of your Goal");
                        string title = Console.ReadLine();
                        Console.WriteLine("Please write a description of your Goal");
                        string discription = Console.ReadLine();
                        Console.WriteLine("How many times would you like to complete this goal?");
                        int number = int.Parse(Console.ReadLine());
                        ChecklistGoal cg = new ChecklistGoal(title, discription, completeCheck, number);
                        goals.Add(cg);
                    }
                    else if (userGoalSelection == 4)
                    {
                        Console.WriteLine("Welcome, A Simple Goal is a single time goal once completed it will be removed,\n The Eternal Goal is a never ending goal but each time it is completed you will earn points\n and the checklist goal will let you complete it a certain number of times to gain a bonus.");
                    } 
                    else 
                    {
                        Environment.Exit(0);
                    }  
                }
                
                
                else if (userDecision == 2)
                {
                  foreach (Goal g in goals)
                  Console.WriteLine($"[] {g}");  
                  foreach (Goal cg in completeGoals)
                  Console.WriteLine($"[x] {cg}");
                }
                else if (userDecision == 3)
                {
                    Console.WriteLine("Which Goal would you like to complete?");
                    int i = 1;
                    foreach (Goal g in goals)
                    {
                    Console.WriteLine($"{i}. {g}"); 
                    i++;
                    }
                    int userCompleteGoalSelection = int.Parse(Console.ReadLine());
                    userCompleteGoalSelection = userCompleteGoalSelection - 1;
                    var finishedGoal = goals[userCompleteGoalSelection];
                    completeGoals.Add(finishedGoal);
                    goals.RemoveAt(userCompleteGoalSelection);
                    
                }
                
                else if (userDecision == 4)
                {
                           //Allows user to save the file with a user chosen filename, saved as a .txt file
                
                Console.WriteLine("What would you like to name your file? ");
                string fileName = Console.ReadLine();
                string completeFileName = ($"{fileName}.txt");

                
                using (StreamWriter outputFile = new StreamWriter(completeFileName))
                {
                    foreach (var line in goals)
                    {
                        
                        outputFile.WriteLine($"{line} ~~");

                    }
                    
                }
                    
                }
                else if (userDecision == 5)
                {
                    //Loads file that was saved by the user
                    Console.WriteLine("What File would you like to read?: ");
                    string pullGoal = Console.ReadLine();
                    string completePullGoal = ($"{pullGoal}.txt");
                    string[] lines = System.IO.File.ReadAllLines(completePullGoal);

                    foreach (string line in lines)
                    {
                        var parts = line.Split("~~");
                        
                        goals.Add(parts);
                        
                        
                        //for (int i =0; i < line.Count; i++)
                        //{
                        //    Console.WriteLine(line[i]);
                        //}
                    } 
                }
                else if (userDecision == 6)
                {
                     //Exits program
                    Environment.Exit(0);
                }
        }

        
    }





    static int UserChoice()
        {
            Console.WriteLine(" 1. Set Goal\n 2. Display Goals\n 3. Complete Goals\n 4. Save\n 5. Load\n 6. Quit");
            int userSelection = int.Parse(Console.ReadLine());
            
            return userSelection;
        }

        static void Welcome()
        {
        Console.WriteLine("Welcome to Goaltastic please select an option");

        }
 
}