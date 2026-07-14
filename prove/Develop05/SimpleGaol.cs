using System.Runtime.CompilerServices;

class SimpleGoal : BaseGoal
{
    public SimpleGoal() : base()
    {
        
    }

    public override void CreateGoal()
    {
        SetGoalType("Simple");
        SetName();
        SetDescription();
        SetNumberOfPoints();
    }

    public override int RecordEvent(int total)
    {
        int money = total + MarkComplete();
        return money;
    }
}