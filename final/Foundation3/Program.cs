using System;

class Program
{
    static void Main(string[] args)
    {
       
        LectureEvent LE = new LectureEvent("Lecture", "Meet Elder Holland", "Personal Fireside with Elder Holland", "4th of April", "7pm", "Blackfoot South Stake Center Building","Elder Holland", "300");
        Console.WriteLine(LE.GetStandard());
        Console.WriteLine(LE.GetFullLecture());
        Console.WriteLine(LE.GetShort());
        ReceptionEvent RE = new ReceptionEvent("Reception", "Carrie & Devan's Wedding", "A small reception to celebrate our wedding", "April 8th", "8pm", "204 Johnson rd, Blackfoot ID 83221", "theWedding@gmail.com");
        Console.WriteLine(RE.GetStandard());
        Console.WriteLine(RE.GetFullReception());
        Console.WriteLine(RE.GetShort());
        OutdoorEvent OE = new OutdoorEvent("Outdoor", "Young Mens Campout", "Going to the Thompson's Land for an overnighter, we will carpool from the church", "Saturday the 1st", "7am", "Blackfoot South Stake Building", "Cloudy");
        Console.WriteLine(OE.GetStandard());
        Console.WriteLine(OE.GetFullOutdoor());
        Console.WriteLine(OE.GetShort());
        

    }
}