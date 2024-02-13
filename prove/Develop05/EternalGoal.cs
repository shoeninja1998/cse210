public class EternalGoal:Goal
{
    public EternalGoal(string name, string description, string points)
    :base(name, description, points){}
    public override void RecordEvent()
    {
         Console.WriteLine($"You recorded an event for the eternal goal '{_name}' and earned {_points} points.");
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal-{_name}-{_description}-{_points}";
    }
}