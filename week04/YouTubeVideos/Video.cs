namespace YoutubeVideos;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public Video()
    {
        _title = "Undefined";
        _author = "Undefined";
        _length = 0;
    }

    public int NumberOfComments()
    {
        return _comments.Count();
    }

    public void AddComment(string name, string text)
    {
        Comment newComment = new Comment(name, text);
        _comments.Add(newComment);
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public void SetAuthor(string name)
    {
        _author = name;
    }

    public void SetLength(int time)
    {
        _length = time;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public string GetTitle()
    {
        return _title;
    }

    public int GetLength()
    {
        return _length;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }
}