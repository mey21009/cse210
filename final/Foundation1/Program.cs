using System;

class Program
{
    static void Main(string[] args)
    {
        Video[] _videos = new Video[4];

        _videos[0] = new Video("Enos789", "How to finish all your homework before the deadlines", 200);
        _videos[0].AddComment("Alma456", "Thanks for the tips!");
        _videos[0].AddComment("Nephi123", "...Nephi was here...");
        _videos[0].AddComment("Abinadi109", "This video is not working");

        _videos[1] = new Video("Amulek999", "Come Follow Me-week of May 22-28", 980);
        _videos[1].AddComment("Jared231", "Whoa! Great insights!");
        _videos[1].AddComment("Jacob222", "Is this next week or last week?");
        _videos[1].AddComment("Samuel771", "some one explain this better.");
        
        _videos[2] = new Video("Abinadi109", "Come Follow Me-week of May 29-June 4", 550);
        _videos[2].AddComment("Zoram124", "Love it! Thanks for sharing!");
        _videos[2].AddComment("Lehi231", "very in-depth, I'm impressed.");
        _videos[2].AddComment("King_Noah532", "Laaaaame");

        _videos[3] = new Video("AlmaJr367", "WDD130 Project week 5", 480);
        _videos[3].AddComment("Laban678", "Thanks for the great explanation! ");
        _videos[3].AddComment("Lemuel923", "I'd be so lost without your help.");
        _videos[3].AddComment("Laman101", "this program is lame.");

        for(int i = 0; i < _videos.Length ; i++)
        {
            Console.WriteLine();
            _videos[i].DisplayVideoInfo();
            _videos[i].DisplayVideoComments();
        }
    }
}