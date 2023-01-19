using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Wastewater Operator";
        job1._companyName = "City of Blackfoot";
        job1._startYear = 2019;
        job1._endYear = 2021;

        Job job2 = new Job();
        job2._jobTitle = "Concrete Finisher";
        job2._companyName = "ConcreteCraft";
        job2._startYear = 2021;
        job2._endYear = 2022;

        Resume myResume = new Resume();
        myResume._name = "Spencer Barbre";        
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
        

    
    }
}