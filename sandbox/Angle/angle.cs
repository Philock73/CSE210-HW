class Angle
{
    
    private double _radians;

    public Angle()
    {
        _radians = 0;
    }

    public Angle(int degrees)
    {
        _radians = ToRadians(degrees);
    }

    public Angle(double radians)
    {
        SetRadians(radians);
    }

    public double GetRadians()
    {
        return _radians;
    }

    public void SetRadians(double radians)
    {
        if (radians < 0)
        {
            Console.WriteLine("Invalid Data");
            _radians = 0;
        }
        else
        {
            _radians = radians;        
        }
    }

    private double ToRadians(double degrees)
    {
        return degrees/ 180 * Math.PI;
    }
}