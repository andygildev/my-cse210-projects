using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        List<Video> videos = new List<Video>();

      
        Video v1 = new Video("How to Cook Jollof Rice", "Chef Tunde", 540);
        v1.Comments.Add(new Comment("Andrew", "This looks delicious!"));
        v1.Comments.Add(new Comment("Maria", "I tried it and loved it."));
        v1.Comments.Add(new Comment("James", "Very clear instructions!"));
        videos.Add(v1);

        
        Video v2 = new Video("Top 10 Places to Visit in Nigeria", "TravelPro", 720);
        v2.Comments.Add(new Comment("Sarah", "I want to visit all these places!"));
        v2.Comments.Add(new Comment("Derek", "Great recommendations."));
        v2.Comments.Add(new Comment("Zainab", "Video quality is amazing."));
        videos.Add(v2);

      
        Video v3 = new Video("Beginner’s Guide to C# Programming", "CodeMaster", 900);
        v3.Comments.Add(new Comment("John", "Very helpful tutorial!"));
        v3.Comments.Add(new Comment("Emily", "Thanks! This helped me a lot."));
        v3.Comments.Add(new Comment("Mike", "Please make a part 2."));
        videos.Add(v3);

       
        foreach (Video video in videos)
        {
            Console.WriteLine("================================");
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (Comment c in video.Comments)
            {
                Console.WriteLine($" - {c.Name}: {c.Text}");
            }

            Console.WriteLine(); 
        }
    }
}
