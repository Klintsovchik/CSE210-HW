public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;
    public ChecklistGoal(int target, int bonus, string name, string description, int points) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override int RecordEvent()
    {
        _amountCompleted++;
        if(IsComplete())
        {
            return _points + _bonus;
        }
        else
        {
            return _points;
        }
    }
    public override string GetDetailsString()
    {

        return$"{base.GetDetailsString()} -- Currently completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal: {_shortName},{_description},{_points}, {_bonus},{_target},{_amountCompleted}";
    }

}