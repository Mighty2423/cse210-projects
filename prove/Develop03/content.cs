using System;

// Content class
public class Content
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public string Book => _book;
    public int Chapter => _chapter;
    public int StartVerse => _startVerse;
    public int EndVerse => _endVerse;

    // content public field
    public Content(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = startVerse; // Single verse case
    }

    // content public field
    public Content(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    // Override ToString method
    public override string ToString()
    {
        return _startVerse == _endVerse
            ? $"{_book} {_chapter}:{_startVerse}"
            : $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
    }
}
