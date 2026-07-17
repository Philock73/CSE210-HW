class BaseEvent
{
    private string _eventTitle;

    private string _discription;

    private string _date;

    private int _time;

    private string _address;

    private string _eventType;


    public BaseEvent(string eventType, string eventtitle, string discription, string date, int time, string address)
    {
        _eventTitle = eventtitle;
        _discription = discription;
        _date = date;
        _time = time;
        _address = address;
        _eventType = eventType;
    }

    public void StandardDetails()
    {
        Console.WriteLine(_eventTitle);
        Console.WriteLine(_discription);
        Console.WriteLine(_date);
        Console.WriteLine($"{_time}:00");
        Console.WriteLine(_address);
    }

    public void ShortDiscription()
    {
        Console.WriteLine(_eventType);
        Console.WriteLine(_eventTitle);
        Console.WriteLine(_date);
    }

    public void FullDetails(string additionalInfo)
    {
        Console.WriteLine(_eventType);
        Console.WriteLine(_eventTitle);
        Console.WriteLine(_discription);
        Console.WriteLine(additionalInfo);
        Console.WriteLine(_date);
        Console.WriteLine($"{_time}:00");
        Console.WriteLine(_address);
    }
    public string SetEventType()
    {
        return _eventType;
    }
}