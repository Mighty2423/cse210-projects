public class Comment
{

    // Fields
    // Author of the comment
    // Text of the comment
    private string _author;
    private string _text;

    // Constructor
    // Comment object with author and text
    public Comment(string author, string text)
    {
        _author = author;
        _text = text;
    }

    // Getters (Encapsulation)
    // Getters for author
    public string GetAuthor() => _author;
    // Getters for text
    public string GetText() => _text;
}