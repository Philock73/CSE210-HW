using System;

class Program
{
    
    static void Main(string[] args)
    {
        List<Video> _myVideos = new List<Video>();
        Video myFirstVideo = new Video("SpeedRuns", "Smallant", 3600);
        Video mySecondVideo = new Video("How to Solve a Rubik's Cube","Larry White", 1500);
        Video myThirdVideo = new Video("Horsebetting is illegal for no reason","Phillip Rodrigez", 240);
        Comment meanComment = new Comment("Ronald Cartige", "These are so boring, why do people wath=ch this?");
        Comment niceComment = new Comment("Lucy Barntill","You bring a smile to my face! Keep posting videos please.");
        Comment mehComment = new Comment("Jared Herald", "Nice! Never thought about that before");

        _myVideos.Add(myFirstVideo);
        _myVideos.Add(mySecondVideo);
        _myVideos.Add(myThirdVideo);
        foreach(Video video in _myVideos)
        {
            video.StoreComment(niceComment);
            video.StoreComment(meanComment);
            video.StoreComment(mehComment);
            video.DesplayVideo();
        }

    }
}