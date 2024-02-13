public class ChecklistGoal:Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(int target, int bonus, string name, string description, string points)
    :base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        _amountCompleted++;
        if(IsComplete())
        {
            Console.WriteLine($"Congratulations! You completed the checklist goal '{_name}' and earned a bonus of {_bonus} points.");
        }
    }
    public override bool IsComplete()
    {
        return _amountCompleted == _target;
    }
    public override string GetDetailsString()
    {
        return IsComplete()
            ?$"[X] {_name} ({_description}) -- Currently completed: {_amountCompleted}/{_target}"
            :$"[] {_name} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal-{_name}-{_description}-{_points}-{_amountCompleted}{_target}-{_bonus}";
    }
}