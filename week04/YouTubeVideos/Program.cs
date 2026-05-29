using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        Video video1 = new Video("Someething", "Mr.Morti", 546);
        Video video2 = new Video("Where ca i find peace", "Leonard", 762);
        Video video3 = new Video("Do you love Me?", "Faith", 386);
        Video video4 = new Video("Who is He?", "Truth", 467);

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        video1.AddComment(new Comment("1984", "I like that video, Where did you get this idea?"));
        video1.AddComment(new Comment("John", "This changed my life!"));
        video1.AddComment(new Comment("Anna", "Can you make a part 2?"));
        video2.AddComment(new Comment("Rural", "I want ot find peace"));
        video2.AddComment(new Comment("Zen Master", "Try meditation it helps"));
        video2.AddComment(new Comment("Mike", "I needed this today, thank you"));
        video3.AddComment(new Comment("Mr.Beast", "I don't even know what to think"));
        video3.AddComment(new Comment("Rose", "This made me cry"));
        video3.AddComment(new Comment("Tom", "Beautiful video"));
        video4.AddComment(new Comment("Mr.Who", "What d oi need to do to know Him?"));
        video4.AddComment(new Comment("Sarah", "I have the same question"));
        video4.AddComment(new Comment("Dave", "Very deep and meaningful"));

        
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title - {video.GetTitle()}");
            System.Console.WriteLine($"Author: {video.GetAuthor()}");
            System.Console.WriteLine($"Length - {video.GetLength()} seconds");
            System.Console.WriteLine($"Comments: {video.GetNumberOfComments()}");

            foreach(Comment comment in video.GetComments())
            {
                System.Console.WriteLine($"{comment.GetName()} - {comment.GetText()}");
            }
        }
    }

}