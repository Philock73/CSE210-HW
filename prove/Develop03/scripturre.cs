class Scripture
{
    private string _book;

    private int _chapter;

    private int _startingVerse;

    private int _endVerse;

    private string _reference;

    private List<string> hiddenwords = new List<string>();

    private List<string> words = new List<string>();

    

    public Scripture(string book, int chapter, int startingVerse, string reference)
    {
        _book = book;

        _chapter = chapter;

        _startingVerse = startingVerse;

        _reference = reference;

        string[] split = _reference.Split(" ");

        foreach(string i in split)
        {
            words.Add(i);
        }
    }
    public Scripture(string book, int chapter, int startingVerse, int endVerse, string reference)
    {
        _book = book;

        _chapter = chapter;

        _startingVerse = startingVerse;

        _endVerse = endVerse;

        _reference = reference;

        string[] split = _reference.Split();

        foreach(string i in split)
        {
            words.Add(i);
        }
    }

    public void GetScripture()
    {
        int ammount = words.Count();
        
        int ammounthidden = hiddenwords.Count();
        
        Console.WriteLine(ammount);
        
        while(ammounthidden <= ammount)
        {
            foreach(string word in words)
            {            
                bool hide = CheckHidden(word);
                Word myWord = new Word(word, hide);
                string welcome = myWord.CheckWord(word);
                Console.Write(welcome);
            }
            HideWords();
            ammounthidden = hiddenwords.Count();
            Console.ReadLine();
        }
    }

    public bool CheckHidden(string word)
    {
        bool hide;
        if(hiddenwords.Contains(word))
        {
            hide = true;
        }
        else
        {
            hide = false;
        }
        return hide;
    }
    public void HideWords()
    {
        int hiding = 0;
        while(hiding < 3)
        {
            Random random = new Random();
            string word;
            word = words[Random.Shared.Next(words.Count())];
            if (hiddenwords.Count() < words.Count())
            {
                while (hiddenwords.Contains(word))
                {
                    word = words[Random.Shared.Next(words.Count())];
                }
            }
            hiddenwords.Add(word);
            hiding++;
        }
        
    }
}