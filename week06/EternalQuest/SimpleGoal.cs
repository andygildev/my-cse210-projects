public class SimpleGoal : Goal
{
    private bool _completed;

    public SimpleGoal(string name, string desc, int points, bool completed = false)
        : base(name, desc, points)
    {
        _completed = completed;
    }

    public override int RecordEvent()
    {
        _completed = true;
        return Points;
    }

    public override string GetStatus()
    {
        return _completed ? $"[X] {Name}" : $"[ ] {Name}";
    }

    public override string Serialize()
    {
        return $"Simple|{Name}|{Description}|{Points}|{_completed}";
    }
}
