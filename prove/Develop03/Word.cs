using System.Security.Cryptography.X509Certificates;

class Word
{
    string _word;

    bool _hidden;

    //char[] letters = [];

    public Word(string word)
    {
        _hidden = false;
        
        _word = word;
    }
    public string GetWord()
    {
        string tempword = "";
        if (_hidden)
        {
            foreach (char letter in _word)
            {
                tempword += "_";
            }
        }
        else
        {
            tempword = _word;
        }
        return tempword + " ";
    }
    public bool CheckWord()
    {
        return _hidden;
    }

    public void HideWord()
    {
        _hidden = true;
    }
}