using System;

// WordFunc class
public class WordFunc
{
    private string _text;
    private bool _isHidden;

    public string Text => _text;
    public bool IsHidden => _isHidden;


    public WordFunc(string text)
    {
        _text = text;
        _isHidden = false;
    }
    //hide method
    public void Hide()
    {
        _isHidden = true;
    }
    //override ToString method
    public override string ToString()
    {
        return _isHidden ? "_____" : _text;
    }
}