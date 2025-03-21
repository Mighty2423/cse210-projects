using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Created a list of videos
        List<Video> videos = new List<Video>();
        // Created a video object and added comments to it
        Video _video = new Video("Sintel", "Durian");
        _video.AddComment(new Comment("Alice", "I love this movie!"));
        _video.AddComment(new Comment("Bob", "I hate this movie!"));
        videos.Add(_video);

        Video _video2 = new Video("Big Buck Bunny", "Peach");
        _video2.AddComment(new Comment("Charlie", "I love this movie!"));
        _video2.AddComment(new Comment("David", "I hate this movie!"));
        videos.Add(_video2);

        // Display the videos and their comments for each video and commentor with each text in
        // a foreach loop
        while (true)
        {
            foreach (var video in videos)
            {
                Console.WriteLine("\n Youtube Video:");
                Console.WriteLine($"Title: {video.GetTitle()} | Director: {video.GetDirector()}");
                Console.WriteLine($"Number of comments: {video.GetCommentCount()}");
                Console.WriteLine("Comments section:");
                foreach (var comment in video.GetComments())
                {
                    Console.WriteLine($"- {comment.GetAuthor()}: {comment.GetText()}");
                }
            } break;
        }
    }
        }