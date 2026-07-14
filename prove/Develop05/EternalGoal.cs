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


    public override int RecordEvent(int total)
    {
        int money = total + MarkComplete();
        return money;
    }

}