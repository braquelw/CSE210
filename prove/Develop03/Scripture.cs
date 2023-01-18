using System;

public class Scripture
{
    private string _reference { get; set; }
    private string _text { get; set; }

    public Scripture()
    {
        _reference = "";
        _text = "";
    }
    public Scripture(string reference)
    {
        _reference = reference;
        _text = "";
    }
    public Scripture(string reference, string text)
    {
        _reference = reference;
        _text = text;
    }

    public string GetScripture()
    {
        string scripture = $"{_reference} {_text}";
        return scripture;
    }
}