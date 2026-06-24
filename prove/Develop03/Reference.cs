class ScriptureTitle
{
    public string _book;

    public int _chapter;

    public string _verses;

    public ScriptureTitle(string book, int chapter, string verses)
    {
        _book = book;

        _chapter = chapter;

        _verses = verses;

    }

    public string GetDisplayString()
    {
        return $"{_book} {_chapter}: {_verses}";
    }

}