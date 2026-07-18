class Running : BaseActivity
{
    private float _runningdistance;

    public Running(float runningdistance, string date, int length, float distance, float speed, float pace) : base (date, length, distance, speed, pace)
    {
        _runningdistance = runningdistance;
    }

    public override (string, float) GetInfo()
    {
        return ("Running", _runningdistance);
    }

    
}