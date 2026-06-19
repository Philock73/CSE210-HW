class Scripture
{
    private string _book;

    private int _chapter;

    private int _startingVerse;

    private int _endVerse;

    private string _reference;

    string[] words;

    public Scripture(string book, int chapter, int startingVerse, string reference)
    {
        _book = book;

        _chapter = chapter;

        _startingVerse = startingVerse;

        _reference = reference;
    }
    public Scripture(string book, int chapter, int startingVerse, int endVerse, string reference)
    {
        _book = book;

        _chapter = chapter;

        _startingVerse = startingVerse;

        _endVerse = endVerse;

        _reference = reference;
    }

    public void GetScripture()
    {
        words = _reference.Split(" ");
        foreach(string word in words)
        {
            Console.Write(word + " ");
        }
    }
}