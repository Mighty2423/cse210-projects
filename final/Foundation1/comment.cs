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
    // The '=>' syntax is a lambda expression that defines a method returning _author
    // without needing a full method body.
    // This is a shorthand way to write a method that returns a single value.
    // It is equivalent to writing a method with a return statement.
    // The method returns the value of the private field _author.
    // This is a common pattern in C# to provide access to private fields while keeping them encapsulated.
    // The method is public, meaning it can be accessed from outside the class.
    public string GetCommentAuthor() => _author;
    // Getters for text
    public string GetText() => _text;
}