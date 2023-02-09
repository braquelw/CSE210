using System;


public class Comment
{
    public string _commenterName;
    public string _commentText;

    public void Display()
    {
        Console.WriteLine($"  {_commenterName}: {_commentText}");
    }
}