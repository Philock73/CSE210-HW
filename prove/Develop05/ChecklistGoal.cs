class ChecklistGoal : BaseGoal
{
    public ChecklistGoal() : base()
    {
        
    }

    public override void CreateGoal()
    {
        SetName();
        SetDescription();
        SetNumberOfPoints();

    }

    public override void RecordEvent()
    {
        
    }
}