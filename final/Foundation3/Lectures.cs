class Lectures : BaseEvent
{

    private int _capacity;

    private string _speaker;

    public Lectures(string speaker, int capacity, string eventType,  string eventtitle, string discription, string date, int time, string address): base (eventType, eventtitle, discription, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string SetAdditionalInfo()
    {
        return _speaker + _capacity;
    }
}