public abstract class Goal
{
    protected string _name;
    protected string _description;
    public string _points;
    public Goal(string name, string description, string points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        // How do you display just a goal's name?
        return $"{_name}";
    }
    public abstract string GetStringRepresentation();
}