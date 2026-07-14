class ChecklistGoal : BaseGoal
{
    public ChecklistGoal() : base()
    {
        
    }

    public override void CreateGoal()
    {
        SetGoalType("Checklist");
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