class Cycling : BaseActivity
{
    private float _bikespeed;

    public Cycling(float bikespeed, string date, int length, float distance, float speed, float pace) : base (date, length, distance, speed, pace)
    {
        _bikespeed = bikespeed;
    }
    public override (string, float) GetInfo()
    {
        return ("Cycling", _bikespeed);
    }
}