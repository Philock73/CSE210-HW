class EternalGoal : BaseGoal
{
    public EternalGoal() : base()
    {
        
    }

    public override void CreateGoal()
    {
        SetGoalType("Eternal");
        SetName();
        SetDescription();
        SetNumberOfPoints();
    }


    public override void RecordEvent()
    {
        
    }

}