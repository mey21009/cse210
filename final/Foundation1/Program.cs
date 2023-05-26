using System;

class Program
{
    static void Main(string[] args)
    {
        Video[] _videos = new Video[4];

        _videos[0] = new Video("Enos789", "How to finish all your homework before the deadlines", 200);
        _videos[0].AddComment("Alma456", "Thanks for the tips!");
        _videos[0].AddComment("Nephi123", "Nephi was here");
        _videos[0].AddComment("Abinadi109", "This video is not working");

        _videos[1] = new Video("Amulek999", "BEST CLIPS OF THE MONTH FORTNITE", 980);
        _videos[1].AddComment("Jared231", "nice headshot at 2:40!");
        _videos[1].AddComment("Jacob222", "this guy doesn't know how to play!!!!");
        _videos[1].AddComment("Samuel771", "bruh");
        
        _videos[2] = new Video("Abinadi109", "How to create a PS1 style horror game in Unity | Tutorial", 550);
        _videos[2].AddComment("Zoram124", "Something about these retro-styled graphics that speaks to me");
        _videos[2].AddComment("Lehi231", "I do love the video, I wouldn't mind more indepth as well as beginner friendly tutorials similar to this one!");
        _videos[2].AddComment("King_Noah532", "finally someone explained the thing i wanted to learn in the best and simple way, thank you so much.");

        _videos[3] = new Video("AlmaJr367", "Making an OPEN WORLD for my INDIE GAME - Resttore Devlog #1", 480);
        _videos[3].AddComment("Laban678", "Great work. Can I know how much time it took to create this scene in total?");
        _videos[3].AddComment("Lemuel923", "Sir which pc you used unity or unreal engine 5?????????");
        _videos[3].AddComment("Laman101", "");

        for(int i = 0; i < _videos.Length ; i++)
        {
            Console.WriteLine();
            _videos[i].DisplayVideoInfo();
            _videos[i].DisplayVideoComments();
        }
    }
}