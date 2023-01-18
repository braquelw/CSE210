using System;

public class Reference
{
    private string _book { get; set; }
    private int _chapter { get; set; }
    private int _verseStart { get; set; }
    private int _verseEnd { get; set; }

    public Reference()
    {
        _book = "unknown";
        _chapter = 0;
        _verseStart = 0;
        _verseEnd = 0;
    }
    public Reference(string book, int chapter, int verseStart)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = 0;
    }
    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
    }

    public string GetReference()
    {
        if (_verseEnd > 1)
        {
            string reference = $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";
            return reference;
        }
        else
        {
            string reference = $"{_book} {_chapter}:{_verseStart}";
            return reference;
        }
    }
}