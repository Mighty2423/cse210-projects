using System;
using System.Collections.Generic;
using System.Linq;

// Scripture class
public class Scripture
{
    // Fields
    private Content _reference;
    private List<WordFunc> _words;
    private Random _random = new Random();
    // scripture constructor
    public Scripture(Content reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new WordFunc(word)).ToList();
    }
    //hide random words
    public bool HideRandomWords(int count)
    {
        var visibleWords = _words.Where(word => !word.IsHidden).ToList();
        if (visibleWords.Count == 0) return false; // All words are hidden

        int wordsToHide = Math.Min(count, visibleWords.Count);
        for (int i = 0; i < wordsToHide; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }

        return true; // Words still remain
    }
    //override ToString method
    public override string ToString()
    {
        return $"{_reference}\n{string.Join(" ", _words)}";
    }
}