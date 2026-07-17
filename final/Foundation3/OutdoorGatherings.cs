class OutDoorGatherings : BaseEvent
{
    private string _weather;


    public OutDoorGatherings(string weather, string eventType, string eventtitle, string discription, string date, int time, string address): base (eventType, eventtitle, discription, date, time, address)
    {
        _weather = weather;
    }
    public string SetAdditionalInfo()
    {
        return _weather;
    }
    

}