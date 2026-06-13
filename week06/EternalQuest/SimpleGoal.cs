public class SimpleGoal : Goal
{
    private bool _isComplete = false;
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override int RecordEvent()
    {
        _isComplete = true;
        return _points;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal: {_shortName},{_description},{_points},{_isComplete}";
    }

}