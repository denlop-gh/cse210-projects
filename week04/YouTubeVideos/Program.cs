using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Basic programming", "Dennis Lopez", 300);
        video1.AddComment(new Comment("Jamie", "Great video!"));
        video1.AddComment(new Comment("Mark", "Very informative."));
        video1.AddComment(new Comment("Dylan", "Thanks for sharing!"));
        videos.Add(video1);

        Video video2 = new Video("Advanced programming", "John Smith", 600);
        video2.AddComment(new Comment("Thomas", "Loved the examples!"));
        video2.AddComment(new Comment("Dina", "This helped me a lot."));
        video2.AddComment(new Comment("Juana", "Excellent explanation!"));
        videos.Add(video2);

        Video video3 = new Video("Programming tips", "Joana Johnson", 450);
        video3.AddComment(new Comment("Justin", "Very useful tips!"));
        video3.AddComment(new Comment("Chris", "I learned a lot from this."));
        video3.AddComment(new Comment("Martha", "Keep up the good work!"));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.Display();
            Console.WriteLine();
        }
    }
}