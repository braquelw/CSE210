using System;


public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    public void Display()
    {
        Console.WriteLine($"Title: {_title} ({_length} seconds)");
        Console.WriteLine($"Author: {_author}");
        int listCount = _comments.Count;
        Console.WriteLine($"Comments ({listCount}):");

        foreach (Comment comment in _comments)
        {
            comment.Display();
        }

        Console.WriteLine();
    }
}