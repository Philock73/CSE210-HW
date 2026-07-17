using Microsoft.VisualBasic;

class Comment
{
    private string _name;

    private string _comment;

    public Comment(string name, string text)
    {
        _name = name;
        _comment = text;
    }
    public string GiveInfo()
    {
        return $"{_name}: {_comment}";
    }
}