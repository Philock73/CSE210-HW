

using System.Reflection;
using System.Runtime.CompilerServices;

abstract class BaseGoal
{
    private string _name;

    private string _description;

    private int _numberOfPoints;

    private bool _status;

    private string _goalType;

    public BaseGoal()
    {
        _name = "";
        _description = "";
        _numberOfPoints = 0;
        _status = false;
        _goalType = "";
    }

    public void SetName()
    {
        Console.Write("What is the name of your goal: ");
        _name = Console.ReadLine();

    }
    public void SetDescription()
    {
        Console.Write($"Enter the description for {_name} goal: ");
        _description = Console.ReadLine();

    }
    public void SetNumberOfPoints()
    {
        Console.Write($"Enter the points for {_name} goal: ");
        _numberOfPoints = int.Parse(Console.ReadLine());
    }

    public virtual string GetDesplayString()
    {
        char status = ' ';
        if (_status)
        {
            status = 'X';
        }
        return ($"[{status}] Name: {_name}, Description: {_description}, Points: {_numberOfPoints}");
    }

    public int MarkComplete()
    {
        _status = true;
        return _numberOfPoints;
    }

    public abstract void CreateGoal();

    public abstract void RecordEvent();
}