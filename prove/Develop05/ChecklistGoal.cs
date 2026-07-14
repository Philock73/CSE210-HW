using System.Data.SqlTypes;

class ChecklistGoal : BaseGoal
{
    private int _ammount;
    public ChecklistGoal() : base()
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
        int i = 1;
        int money = 0;
        i++;
        if(i < _ammount)
        {   
            money = total + MarkComplete();
        }
        else if(i == _ammount)
        {
            money = total + (MarkComplete() * 10);
        }
        return money;
        
    }
}