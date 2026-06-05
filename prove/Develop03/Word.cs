using System.Security.Cryptography.X509Certificates;

class Word
{
    string _word;

    bool _hidden;

    public Word(string word, bool hidden)
    {
        char[] letters = [];
            
        if (hidden)
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