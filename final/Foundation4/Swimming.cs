class Swimming : BaseActivity
{
    private int _laps;

    public Swimming(int laps, string date, int length, float distance, float speed, float pace) : base (date, length, distance, speed, pace)
    {
        _laps = laps;
    }
    public override (string, float) GetInfo()
    {
        return ("Swimming", _laps);
    }
}