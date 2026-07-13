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

    public override void RecordEvent()
    {
        
    }
}