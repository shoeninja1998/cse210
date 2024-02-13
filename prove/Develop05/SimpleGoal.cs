public class SimpleGoal:Goal
{
    private bool _isComplete;
    public SimpleGoal(bool isComplete, string name, string description, string points)
    :base(name, description, points)
    {
        _isComplete = isComplete;
    }
    public override void RecordEvent()
    {
        _isComplete = true;
         Console.WriteLine($"You recorded an event for the simple goal '{_name}' and earned {_points} points.");
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetDetailsString()
    {
        return _isComplete ? $"[X] {_name} ({_description})" : $"[] {_name} ({_description})";
    }
public override string GetStringRepresentation()
    {
        return $"SimpleGoal-{_name}-{_description}-{_points}-{_isComplete}";
    }
}