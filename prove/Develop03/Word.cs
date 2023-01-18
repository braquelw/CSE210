using System;

public class Word
{
    private string _word { get; set; }

    public Word()
    {
        _word = "";
    }
    public Word(string word)
    {
        _word = word;
    }

    public string GetUnderscores()
    {
        string underscoreWord = (new string(_word.Select(c => char.IsLetter(c) ? '_' : c).ToArray()));
        return underscoreWord;
    }
}