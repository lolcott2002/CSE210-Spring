public class Program
{
    public static void Main(string[] args)
    {
        //this will store everything for the videos
        List<Video> videos = new List<Video>();

        //I made 4 videos to test the program with
        Video video1 = new Video("Why You Are Single", "GetMarried", 1112);
        video1.AddComment(new Comment("beans", "So that's what I've been doing wrong!"));
        video1.AddComment(new Comment("ToastEater4000", "So there is hope for me!"));
        video1.AddComment(new Comment("AvacadosRyum", "sweet!"));
        video1.AddComment(new Comment("ImFromTheUK", "I learned nothing from this. L video."));
        videos.Add(video1);

        Video video2 = new Video("How to Not Die From Grizzly Bears", "Johnson Outdoors", 3200);
        video2.AddComment(new Comment("Outside Guy", "My great uncle needed to watch this before his trip to Alaska back in 76'."));
        video2.AddComment(new Comment("Baskin'", "Idk why I'm watching this I live in Manhattan"));
        video2.AddComment(new Comment("JellyBeans", "wow cool!"));
        videos.Add(video2);

        Video video3 = new Video("You need to invest in BottleCoin now!", "Investor Wisdom", 4513218);
        video3.AddComment(new Comment("CronichallyOnline", "yo why is this video so long?"));
        video3.AddComment(new Comment("RichDad", "I missed out on bitcoin I'm not missing this!"));
        video3.AddComment(new Comment("haricots", "Je ne comprends pas l'anglais"));
        video3.AddComment(new Comment("TikTok_User", "Oops wrong platfrom"));
        videos.Add(video3);

        Video video4 = new Video("5 second cat video", "Daily5SecondCatVideo", 5);
        video4.AddComment(new Comment("GenZ", "Thats the best video I've ever seen"));
        video4.AddComment(new Comment("Gavhsvye", "I sure hope he posts again tomorrw"));
        video4.AddComment(new Comment("BeesKnees", "I didn't like that video at all. Unfollowing."));
        videos.Add(video4);

        //goes throught the list
        Console.WriteLine("Here is the data on the youtube videos:\n");
        Console.WriteLine("\n");

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Creator: {video.GetCreator()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.NumberOfComments()}");
            Console.WriteLine("Comments:");

            if (video.NumberOfComments() > 0)
            {
                foreach (Comment comment in video.GetComments())
                {
                    Console.WriteLine($"   - {comment.GetCommenter()}: \"{comment.GetCommentWords()}\"");
                }
            }
            else
            {
                Console.WriteLine("   No comments yet.");
            }
            Console.WriteLine("\n-------------------------------------\n");
        }

        //lets you close the program
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}