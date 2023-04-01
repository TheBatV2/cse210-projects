using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        RunningActivity run = new RunningActivity("1st April",  30, "Running", 3);
        activities.Add(run);
        CyclingActivity cycling = new CyclingActivity("3rd April", 45, "Cycling", 15);
        activities.Add(cycling);
        SwimmingActivity swimming = new SwimmingActivity("5th April", 60, "Swimming", 10);
        activities.Add(swimming);


        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
           
        }

    }
}