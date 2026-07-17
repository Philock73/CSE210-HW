class Reception : BaseEvent
{
    private string _RSVP;

    public Reception(string RSVP, string eventType, string eventtitle, string discription, string date, int time, string address): base (eventType, eventtitle, discription, date, time, address)
    {
        _RSVP = RSVP;
    }

    public string SetAdditionalInfo()
    {
        return _RSVP;
    }
}