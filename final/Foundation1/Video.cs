class Video
{
    private string _title;

    private string _author;

    private int _length;

    private List<string> _comments = new List<string>();

    public Video(string title, string author, int length)
    {
        _length = length;
        _author = author;
        _title = title;
    }

    public void StoreComment(Comment info)
    {
        _comments.Add(info.GiveInfo());
    }
    
    public string DesplayInfo()
    {
        return $"{_author} wrote {_title} and is {_length} seconds long";
    }
    public int GetCommentAmmount()
    {
        return _comments.Count();
    }
    public void DesplayVideo()
    {
        Console.WriteLine(DesplayInfo());
        Console.WriteLine("\n");
        foreach(string comment in _comments)
        {
            Console.WriteLine(comment);
        }
    }
}