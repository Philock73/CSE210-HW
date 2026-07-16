class EternalGoal : BaseGoal
{
    public EternalGoal() : base()
    {
        
    }

    public EternalGoal(string goalType, string name, string description, int numberofPoints, bool status, int ammount, int completed) : base (goalType, name, description, numberofPoints, status, ammount, completed)
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