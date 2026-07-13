class EternalGoal : BaseGoal
{
    public EternalGoal() : base()
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