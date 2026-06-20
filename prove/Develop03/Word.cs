using System.Security.Cryptography.X509Certificates;

class Word
{
    string _word;

    bool _hidden;

    char[] letters = [];

    public Word(string word, bool hidden)
    {
        _hidden = hidden;
        
        _word = word;
    }
    public string CheckWord(string word)
    {
        if (!_hidden)
        {
            _word = "";
            letters = word.ToCharArray();
            foreach (char letter in letters)
            {
                _word += "_";
    
            }

        }
        else
        {
            _word = word;
        }
        return _word;
    }
}