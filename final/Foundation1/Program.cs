using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        video = new Video("Sintel", "Durian");
        video.AddComment(new Comment("Alice", "I love this movie!"));
        video.AddComment(new Comment("Bob", "I hate this movie!"));
        video = new Video("Big Buck Bunny", "Peach");
        video.AddComment(new Comment("Charlie", "I love this movie!"));
        video.AddComment(new Comment("David", "I hate this movie!"));

        
        Console.WriteLine($"Video title {video.Title}");
        Console.WriteLine($"Creator/director {video.Director}");
        Console.WriteLine($"number of comments {video.GetCommentCount()}");
        Console.WriteLine("Comments:");
        foreach (var comment in video.GetComment())
        {
            Console.WriteLine($"{comment.Author}: {comment.Text}");
        }
    }
}