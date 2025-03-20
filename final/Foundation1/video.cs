
public class Video
{
    public string Title { get; }
    public string Director { get; }
    private List<Comment> comments = new List<Comment>();

    public Video(string title, string director)
    {
        Title = title;
        Director = director;
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return comments.Count;
    }
    
    public List<Comment> GetComment()
    {
        return comments;
    }
}