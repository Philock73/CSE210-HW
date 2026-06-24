class Scripture
{
    private string _book;

    private int _chapter;

    private int _startingVerse;

    private int _endVerse;

    private int _hiddenMax = 0;

    private string _reference;

    List<string> words = new List<string>();

    List<string> hiddenwords = new List<string>();

    public Scripture(){}
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
            hiddenwords.Add(i);
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

            hiddenwords.Add(i);

        }
    }

    public void GetScripture()
    {
        int ammount = words.Count();
        
        int ammounthidden = _hiddenMax;
        
        Console.WriteLine(ammount);
        
        do
        {
            foreach(string word in words)
            {            
                bool hide = CheckHidden(word, hiddenwords);
                Word myWord = new Word(word, hide);
                string action = myWord.CheckWord(word);
                Console.Write(action + " ");
            }
            HideWords(words, hiddenwords);
            ammounthidden = _hiddenMax;
            Console.ReadLine();
            Console.Clear();
            Console.Write("\n\n\n");
        }while(ammounthidden < ammount);
    }

    public bool CheckHidden(string word, List<string> hiddenwords)
    {
        bool hide;
        int location = words.IndexOf(word);
        if(words[location] == hiddenwords[location])
        {
            hide = true;
        }
        else
        {
            hide = false;
        }
        return hide;
    }
    public void HideWords(List<string> words, List<string> hiddenwords)
    {
        int hiding = 0;
        while(hiding < 3)
        {
            Random random = new Random();

            string word;

            word = words[random.Next(words.Count())];
            if(_hiddenMax < words.Count())
            {
                while (words.IndexOf(word) != hiddenwords.IndexOf(word))
                {
                    word = words[Random.Shared.Next(words.Count())];
                }
            
            hiddenwords.Insert(words.IndexOf(word), " ");

            
            }

            _hiddenMax++;

            if(_hiddenMax == words.Count())
            {
                hiding = 3;
            }
            else
            {
                hiding++;
            }          
        }
        
    }

    public Scripture GetRandom()
    {
        List<Scripture> Scriptures = new List<Scripture>()
    {
        new Scripture("1 Nephi", 3, 7, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."),
        new Scripture("St John", 1, 1, "In the beggining was the Word, and the Word was with God, and the Word was God."),
        new Scripture("2 Nephi", 2, 24, 25, "But behold, all things have been done in the wisdom of him who knoweth all things \n Adam fell that men might be; and men are, that they might have joy."),
        new Scripture("Alma", 5, 19, 20, "I say unto you, can ye look up to God at that day with a pure heart and clean hands? I say unto you, can you look up, having the image of God engraven upon your countenances? \n I say unto you, can ye think of being saved when you have yeilded yourselves to become subjects to the devil?")
    };
        Random _random = new Random();
        return Scriptures[_random.Next(Scriptures.Count())];
    }   
}