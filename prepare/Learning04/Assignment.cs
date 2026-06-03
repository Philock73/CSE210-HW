class Assignment
{
    private string _info;
    private string _studentName;

    private string _topic;

    public Assignment(string topic, string studentName)
    {
        _topic = topic;
        _studentName = studentName;
    }
    public string GetSummary()
    {
        _info = _studentName + " " + _topic;

        return _info;
    }
}
