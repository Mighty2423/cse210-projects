
public class Video
{
    private string _title;
    private string _director;
    private List<Comment> _comments = new List<Comment>();

    // Constructor
    public Video(string title, string director)
    {
        _title = title;
        _director = director;
    }

    // Getters (Encapsulation)
    public string GetTitle() => _title;
    public string GetDirector() => _director;

    // Comment management
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }
}