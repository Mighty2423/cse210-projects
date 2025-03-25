
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
    // The '=>' syntax is a lambda expression that defines a method returning _author
    // without needing a full method body.
    // This is a shorthand way to write a method that returns a single value.
    // It is equivalent to writing a method with a return statement.
    // The method returns the value of the private field _author.
    // This is a common pattern in C# to provide access to private fields while keeping them encapsulated.
    // The method is public, meaning it can be accessed from outside the class.
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