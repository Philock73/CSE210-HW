using System.Data.SqlTypes;

class ChecklistGoal : BaseGoal
{
    private int _ammount;
    private int i = 1;
    public ChecklistGoal() : base()
    {
        
    }

    public ChecklistGoal(string goalType, string name, string description, int numberofPoints, bool status, int ammount, int completed) : base (goalType, name, description, numberofPoints, status, ammount, completed)
    {
        
    }
    public override void CreateGoal()
    {
        int limit = SetGoalType("Checklist");
        SetName();
        SetDescription();
        SetNumberOfPoints();
        _ammount = limit;
    }

    public override int RecordEvent(int total)
    {
        int money = 0;
        if(i == _ammount)
        {
            int bonus = MarkComplete() * 10;
            money = total + bonus;
        }
        else
        {   
            money = total + MarkComplete();
        }
        i++;
        return money;
        
    }
}