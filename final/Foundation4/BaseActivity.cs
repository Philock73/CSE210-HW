abstract class BaseActivity
{
    private string _date;

    private int _length;

    private float _distance;

    private float _speed;

    private float _pace;

    private char _plural;

    public BaseActivity(string date, int length, float distance, float speed, float pace)
    {
        _date = date;
        _length = length;
        _distance = distance;
        _speed = speed;
        _pace = pace;
    }

    public abstract (string, float) GetInfo();

    public void CheckPlural()
    {
        if(_distance == 1)
        {
            _plural = ' ';
        }
        else
        {
            _plural = 's';
        }
    }

    public void GetSummarry()
    {
        (string type, float additional) = GetInfo();

        CheckPlural();
        if(type == "Running")
        {
            Console.WriteLine($"{_date} {type}({_length} min)- {additional} mile{_plural}, Speed: {_speed}, Pace: {_pace}");
        }
        else if(type == "Cycling")
        {
            Console.WriteLine($"{_date} {type}({_length} min)- {_distance} mile{_plural}, Speed: {additional}, Pace: {_pace}");
        }
        else if(type == "Swimming")
        {
            Console.WriteLine($"{_date} {type}({_length} min)- {additional} lap{_plural}, Speed: {_speed}, Pace: {_pace}");
        }
        else
        {
            Console.WriteLine("No activity");
        }

        

    }

}