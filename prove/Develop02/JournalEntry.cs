class JournalEntry
{
    string _date;
    string _prompt;
    string _response;
    string[] _prompts =
    {
        "How are you feeling today?",
        "How were your classes today?",
        "How was your activities that you did?"
    };

    public void CreateJournalEntry()
    {
        _date = DateTime.Now.ToShortDateString();
        // finish code to create - need random prompt
        _prompt = _prompts[0];
        Console.WriteLine(_prompt);
        _response = Console.ReadLine();
        
    }
    public JournalEntry()
    {
        _date = "";
        _prompt = "";
        _response = "";
    }
    public JournalEntry(string date, string prompt, string response)
    {
        _date = date;

        _prompt = prompt;

        _response = response;
    }

    public void DisplayJournalEntry()
    {
        Console.WriteLine($"{_date}, {_prompt}, {_response}");
    }
    public string CreateFileSystemString()
    {
        return $"{_date}#{_prompt}#{_response}";
    }
}