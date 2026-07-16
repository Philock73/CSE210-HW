

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

    private int _levelPoints;


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

    public BaseGoal(string goalType, string name, string description, int numberofPoints, bool status, int ammount, int completed)
    {
        _name = name;
        _description = description;
        _numberOfPoints = numberofPoints;
        _status = status;
        _goalType = goalType;
        _ammount = ammount;
        _completed = completed;
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
    public int SetGoalType(string goalType)
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
        return _ammount;
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

    public string GetFileSystemInfo()
    {
        return $"{_goalType}#{_name}#{_description}#{_numberOfPoints}#{_status}#{_ammount}#{_completed}";
    }

    public void AddGoal(BaseGoal goal, List<BaseGoal> myGoals)
    {
       myGoals.Add(goal);
    }

    public void SetLevelPoints(int total)
    {
        _levelPoints = total;
    }

    public int MarkComplete()
    {
        if(_completed != _ammount)
        {  
            _levelPoints =+ _numberOfPoints;
            _completed++;
            if(_completed == _ammount)
            {
                _status = true;
            }
            return _numberOfPoints;
        }
        else
        {
            Console.WriteLine("Sorry but you have already completed the task");
            return 0;
        }
    }

    public void WriteToFile(string filename, List<BaseGoal> myGoals, int total)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(BaseGoal entry in myGoals)
            {
                outputFile.WriteLine(entry.GetFileSystemInfo());
            }
        }
        using (StreamWriter outputFile = new StreamWriter("lvl" + filename))
        {
            outputFile.WriteLine(total);
        }
    }
    public (List<BaseGoal> , int) ReadFromFile(string filename)
    {
        string[] everypoint = System.IO.File.ReadAllLines("lvl" + filename);
        _levelPoints = int.Parse(everypoint[0]);
        string[] lines = System.IO.File.ReadAllLines(filename);
        List<BaseGoal> newFile = new List<BaseGoal>();
        BaseGoal entry = new SimpleGoal();
        foreach (string line in lines)
        {
            string[] parts = line.Split("#");

            string goalType = parts[0];
            string name = parts[1];
            string description = parts[2];
            int numberofPoints = int.Parse(parts[3]);
            bool status = bool.Parse(parts[4]);
            int ammount = int.Parse(parts[5]);
            int completed = int.Parse(parts[6]);

            if(goalType == "Simple")
            {
                entry = new SimpleGoal(goalType, name, description, numberofPoints, status, ammount, completed);
            }
            else if(goalType == "Eternal")
            {
                entry = new EternalGoal(goalType, name, description, numberofPoints, status, ammount, completed);
            }
            else if(goalType == "Checklist")
            {
                entry = new ChecklistGoal(goalType, name, description, numberofPoints, status, ammount, completed);
            }
            newFile.Add(entry);
        }
        return (newFile, _levelPoints);
    }

    public abstract void CreateGoal();

    public abstract int RecordEvent(int total);

}