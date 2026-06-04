class EnglishAssignment : Assignment
{
    private string _title;

    public EnglishAssignment(string topic, string studentName, string title) : base (topic, studentName)
    {
        _title = title;
    } 

    public string GetWritingInfo()
    {
        string info = " ";
        info = GetSummary() + " " + _title;
        return info;
    }
}