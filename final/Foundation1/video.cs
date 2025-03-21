
public class Video
{
    // Fields
    private string _title;
    private string _director;
    private List<Comment> _comments = new List<Comment>();

    // Constructor
    //video object with title and director
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

    // Getters for comments list
    public List<Comment> GetComments()
    {
        return _comments;
    }

    //Getters for comment count
    public int GetCommentCount()
    {
        return _comments.Count;
    }
}