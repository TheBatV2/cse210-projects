using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Polyphia", "Nightmare", "246");
        video1.comment("Sara", "Great Video");
        video1.comment("Nathan", "Wonderful Video");
        video1.comment("Amber", "Awful Video");
        video1.comment("Joseph", "Nice Video");
        videos.Add(video1);
        

        Video video2 = new Video("Volbeat", "Lola Montes", "267");
        video2.comment("Sara", "Great Video");
        video2.comment("Nathan", "Wonderful Video");
        video2.comment("Amber", "Awful Video");
        video2.comment("Joseph", "Nice Video");
        videos.Add(video2);
      
        

        Video video3 = new Video("ColBreakz", "40.000", "233");
       
        video3.comment("Sara", "Great Video");
        video3.comment("Nathan", "Wonderful Video");
        video3.comment("Amber", "Awful Video");
        video3.comment("Joseph", "Nice Video");
        videos.Add(video3);
        

        Video video4 = new Video("Em Behold", "Painful Truth", "209");
        video4.comment("Sara", "Great Video");
        video4.comment("Nathan", "Wonderful Video");
        video4.comment("Amber", "Awful Video");
        video4.comment("Joseph", "Nice Video");
        videos.Add(video4);
      

        foreach (Video v in videos)
        {
            v.DisplayVideo();
        }

    }
}