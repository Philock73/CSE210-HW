using System.Security.Cryptography.X509Certificates;

class Word
{
    string _word;

    bool _hidden;

    char[] letters = [];

    public Word(string word, bool hidden)
    {
        _hidden = hidden;
        
    }
    public void CheckWord(string word)
    {
        if (_hidden)
        {
            letters = word.ToCharArray();
            foreach (char letter in letters)
            {
                Console.Write("_");
            }

        }
        else
        {
            _word = word;
        }
    }
}