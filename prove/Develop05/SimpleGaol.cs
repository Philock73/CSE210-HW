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

    public override void RecordEvent()
    {
        // populate later   
    }
}