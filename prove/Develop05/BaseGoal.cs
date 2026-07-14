

using System.Reflection;
using System.Runtime;
using System.Runtime.CompilerServices;

abstract class BaseGoal
{
    private string _name;

    private string _description;

    private int _numberOfPoints;

    private bool _status;

    private string _goalType;

    private int _ammount;

    private int _completed;

    private List<BaseGoal> _goals = new List<BaseGoal>
    {
        new SimpleGoal(),
        new EternalGoal(),
        new ChecklistGoal()
    };

    public BaseGoal()
    {
        _name = "";
        _description = "";
        _numberOfPoints = 0;
        _status = false;
        _goalType = "";
        _ammount = 0;
        _completed = 0;

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
    public void SetGoalType(string goalType)
    {
        _goalType = goalType;
        if(goalType == "Simple")
        {
            _ammount = 1;
        }
        else if(goalType == "Eternal")
        {
            _ammount = 9999;
        }
        else
        {
            Console.Write("How many times do you want to do it?\n > ");
            int limit = int.Parse(Console.ReadLine());
            while(limit < 1)
            {
                Console.Write("Please write a correct input.\n > ");
                limit = int.Parse(Console.ReadLine());
            }
            _ammount = limit;
        }
    }
    public void SetNumberOfPoints()
    {
        Console.Write($"Enter the points for one completion of '{_name}' goal: ");
        _numberOfPoints = int.Parse(Console.ReadLine());
    }

    public virtual string GetDesplayString()
    {
        char status = ' ';
        if (_status)
        {
            status = 'X';
        }
        return $"[{status}] Type: {_goalType} Name: {_name}, Description: {_description}, Points: {_numberOfPoints}, Completion progress {_completed}/{_ammount}";
    }

    public void AddGoal(BaseGoal goal)
    {
        _goals.Append(goal);
    }

    public int MarkComplete()
    {
        _completed++;
        if(_completed == _ammount)
        {
            _status = true;
        }
        return _numberOfPoints;
    }

    public void WriteToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(BaseGoal entry in _goals)
            {
                outputFile.WriteLine(entry.GetDesplayString());
            }
        }
    }
    public void ReadFromFile(string filename)
    {
        foreach (BaseGoal goal in _goals)
        {
            this.AddGoal(goal);
        }
    }

    public abstract void CreateGoal();

    public abstract void RecordEvent();

}